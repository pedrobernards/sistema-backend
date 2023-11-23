
using ProgramacaoDoZero.Entities;
using ProgramacaoDoZero.Models;
using ProgramacaoDoZero.Repositories;
using ProgramacaoZero.Api.Common;
using System;

namespace ProgramacaoDoZero.Services
{
    public class UsuarioService
    {
        private string _connectionString;
        private object repository;
        private object usuarioRepository;

        public UsuarioService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public LoginResult Login(string email, string senha)
        {
            var result = new LoginResult();

            var usuarioExistente = new UsuarioRepository(_connectionString).ObterPorEmail(email);

            if (usuarioExistente != null)
            {
                if (usuarioExistente.Senha == senha)
                {
                    //faz login
                    result.sucesso = true;
                    result.usuarioGuid = usuarioExistente.UsuarioGuid;
                }
                else
                {
                    result.sucesso = false;
                    result.mensagem = "Usuário ou senha inválidos";
                }
            }
            else
            {
                result.sucesso = false;
                result.mensagem = "Usuário ou senha inválidos";
            }

            return result;
        }

        public CadastroResult Cadastro(string nome, string sobrenome, string telefone, string email, string genero, string senha)
        {
            var result = new CadastroResult();

            var repositorio = new UsuarioRepository(_connectionString);

            var usuario = repositorio.ObterPorEmail(email);

            if (usuario != null)
            {
                result.sucesso = false;
                result.mensagem = "Usuário já existe no sistema";
            }
            else
            {

                usuario = new Usuario();

                usuario.Email = email;
                usuario.Nome = nome;
                usuario.Sobrenome = sobrenome;
                usuario.Telefone = telefone;
                usuario.Senha = senha;
                usuario.Genero = genero;
                usuario.UsuarioGuid = Guid.NewGuid();


                var affectedRows = repositorio.Inserir(usuario);

                if (affectedRows > 0)
                {
                    result.sucesso = true;
                    result.usuarioGuid = usuario.UsuarioGuid;
                }
                else
                {
                    result.sucesso = false;
                    result.mensagem = "Não foi possível inserir o usuário";
                }
            }
            return result;
        }

        public EsqueceuSenhaResult EsqueceuSenha(string email)
        {
            var result = new EsqueceuSenhaResult();

            var usuario = new UsuarioRepository(_connectionString).ObterPorEmail(email);

            if (usuario == null)
            {
                result = "Usuário não existe";
            }
            else
            {
                var assunto = "Programação do Zero - Recuperar Senha";

                var corpo = "Sua senha de acesso é: " + usuario.Senha;


                var emailSender = new EmailSender();

                emailSender.Enviar(assunto, corpo, usuario.Email);

                result.sucesso = true;


            }

            return result;
        }

        public Usuario ObterUsuario(Guid usuarioGuid)
        {
            var usuario = new UsuarioRepository(_connectionString).ObterPorGuid(usuarioGuid);

            return usuario;
        }
    }
}