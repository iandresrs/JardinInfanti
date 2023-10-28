using System;


namespace JardinInfantil.modelo
{
    internal class ListaJardin
    {

        private string numeroRegistroCivil;
        private string nombreCompleto;
        private string condicionEspecial;
        private string estrato;
        private string fechaNacimiento;
        private string terapia;

        public ListaJardin()
        {
        }

        public ListaJardin(string numeroRegistroCivil, string nombreCompleto, string condicionEspecial, string estrato, string fechaNacimiento, string terapia)
        {
            this.numeroRegistroCivil = numeroRegistroCivil;
            this.nombreCompleto = nombreCompleto;
            this.condicionEspecial = condicionEspecial;
            this.estrato = estrato;
            this.fechaNacimiento = fechaNacimiento;
            this.terapia = terapia;
        }

        public string NumeroRegistroCivil
        {
            get => numeroRegistroCivil;
            set => numeroRegistroCivil = value;
        }

        public string NombreCompleto
        {
            get => nombreCompleto;
            set => nombreCompleto = value;
        }

        public string CondicionEspecial
        {
            get => condicionEspecial;
            set => condicionEspecial = value;
        }

        public string Estrato
        {
            get => estrato;
            set => estrato = value;
        }

        public string FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }

        public string Terapia
        {
            get => terapia;
            set => terapia = value;
        }
    }
}
