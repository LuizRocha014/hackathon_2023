using Hackathon_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.ViewModels.ViewModelAdicionadas
{
    public class HistoricoViewModel :BaseViewModel
    {

        private List<Animal> _listHistorico;


        public List<Animal> ListHistorico { get { return _listHistorico; } set { _listHistorico = value; OnPropertyChanged("ListHistorico"); } }

        public HistoricoViewModel()
        {
        }

        public void CarregaDados()
        {

            var list = new List<Animal>();
            var teste = new Animal()
            {
                Nome = "Toby",
                Especie = "Beagle",
                Porte = "Médio",
                Sexo = "Masculino",
                DtNacimento = "12/04/2022",
                Obs = "Carinhoso e brincalhão",
                Foto = "cachorro1.png",


            };
            list.Add(teste);
            var teste1 = new Animal()
            {
                Nome = "Pipoca",
                Especie = "Akita",
                Porte = "Grande",
                Sexo = "Feminino",
                DtNacimento = "01/02/2020",
                Obs = "Leal, amigo e brincalhão",
                Foto = "cachorro2.png",

            };
            list.Add(teste1);
            var teste2 = new Animal()
            {
                Nome = "Thor",
                Especie = "Boxer",
                Porte = "Grande",
                Sexo = "Masculino",
                DtNacimento = "01/01/2017",
                Obs = "Leal, afetuoso e brincalhão",
                Foto = "cachorro3.png"
            };
            list.Add(teste2);
            var teste3 = new Animal()
            {
                Nome = "Billy",
                Especie = "Chow chow",
                Porte = "Grande",
                Sexo = "Masculino",
                DtNacimento = "24/05/2021",
                Obs = "Calmo, leal e orgulhoso",
                Foto = "cachorro4.png"
            };
            list.Add(teste3);
            ListHistorico = new List<Animal>(list);
        }
    }
}
