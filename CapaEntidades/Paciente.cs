using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Paciente
    {
        #region Atributos
        private int HClinica;
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private int Edad;
        private float Altura;
        private float Peso;
        private bool Lentes;
        private float IMC;
        #endregion

        #region Propiedades
        public int PHClinica
        {
            set { HClinica = value; }
            get { return HClinica; }
        }
        public int PEdad
        {
            set { Edad = value; }
            get { return Edad; }
        }
        public float PAltura
        {
            set { Altura = value; }
            get { return Altura; }
        }
        public float PPeso
        {
            set { Peso = value; }
            get { return Peso; }
        }
        public string PNombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public string PApellido
        {
            set { Apellido = value; }
            get { return Apellido; }
        }
        public string PDireccion
        {
            set { Direccion = value; }
            get { return Direccion; }
        }
        public bool PLentes
        {
            set { Lentes = value; }
            get { return Lentes; }
        }
        public float PIMC
        {
            get { return IMC; }
        }
        #endregion

        #region Constructores
        public Paciente()
        { }

        public Paciente(int HCln, string Nomb, string Apll, string Dir, int Edd, float Alt, float Pes, bool Len)
        {
            HClinica = HCln;
            Nombre = Nomb;
            Apellido = Apll;
            Direccion = Dir;
            Edad = Edd;
            Altura = Alt;
            Peso = Pes;
            Lentes = Len;
            IMC = ClaculoIMC(Pes, Alt);

        }
        #endregion

        #region Metodos
        protected float ClaculoIMC(float Pes, float Alt)
        {
            float imc;
            imc = Pes / (Alt*Alt);
            return imc;
        }
        #endregion
    }
}
