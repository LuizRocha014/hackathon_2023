using Hackathon_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.ViewModels.ViewModelAdicionadas
{
    public class VeterinarioViewModel : BaseViewModel
    {
        private List<Veterinario> _listVet;


        public List<Veterinario> ListaVet { get { return _listVet; } set { _listVet = value; OnPropertyChanged("ListaVet"); } }

        public VeterinarioViewModel() { 
        }

        public void CarregaDados()
        {

            var list = new List<Veterinario>();
            var teste = new Veterinario()
            {
                Nome= "Dr.Eduardo",
                Especialidade = " Grande Porte",
                CFMV = "27834",
                Imagem = "doctor.png"
            };
            list.Add(teste);
            var teste1 = new Veterinario()
            {
                Nome = "Dr.Katia",
                Especialidade = " Pequeno Porte",
                CFMV = "893724",
                Imagem = "doctor2.png"
            };
            list.Add(teste1);
            var teste2 = new Veterinario()
            {
                Nome = "Dr.Roberto",
                Especialidade = " Grande Porte",
                CFMV = "328474",
                Imagem = "doctor3.png"
            };
            list.Add(teste2);
            var teste3 = new Veterinario()
            {
                Nome = "Dr.Evandro",
                Especialidade = "Médio Porte",
                CFMV = "784524" ,
                Imagem = "doctor4.png"
            };
            list.Add(teste3);
            ListaVet = new List<Veterinario>(list);
        }
        
    }
}
