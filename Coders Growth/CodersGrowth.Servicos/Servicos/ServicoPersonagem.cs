using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Dominio.Interfaces;

namespace CodersGrowth.Servicos.Servicos
{
    public class ServicoPersonagem : IServicoPersonagem
    {
        public ServicoPersonagem(IRepositorioPersonagem PersonagemRepositorioMock)
        {
            _personagemrepositorio = PersonagemRepositorioMock;
        }
        private IRepositorioPersonagem _personagemrepositorio;
        public List<Personagem> ObterTodos()
        {
            return _personagemrepositorio.ObterTodos();
        }
        public Personagem ObterPorId(int Id)
        {
            return _personagemrepositorio.ObterPorId(Id) ?? throw new Exception("Personagem não encontrado.");
        }
    }
}


