using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillaEdu.clases
{
    class Estudiante
    {
        int cod;
        string apPaterno;
        string apMaterno;
        string nombre;
        string sexo;
        int codApoderado;
        string fechaNacimiento;
        string foto;

        public int Cod
        {
            get
            {
                return cod;
            }

            set
            {
                cod = value;
            }
        }

        public string ApPaterno
        {
            get
            {
                return apPaterno;
            }

            set
            {
                apPaterno = value;
            }
        }

        public string ApMaterno
        {
            get
            {
                return apMaterno;
            }

            set
            {
                apMaterno = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public int CodApoderado
        {
            get
            {
                return codApoderado;
            }

            set
            {
                codApoderado = value;
            }
        }

        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public Estudiante(int cod, string apPaterno, string apMaterno, string nombre, string sexo, int codApoderado, string fechaNacimiento)
        {
            this.Cod = cod;
            this.ApPaterno = apPaterno;
            this.ApMaterno = apMaterno;
            this.Nombre = nombre;
            this.Sexo = sexo;
            this.CodApoderado = codApoderado;
            this.FechaNacimiento = fechaNacimiento;
        }

        public Estudiante(int cod, string apPaterno, string apMaterno, string nombre, string sexo, int codApoderado, string fechaNacimiento, string foto)
        {
            this.Cod = cod;
            this.ApPaterno = apPaterno;
            this.ApMaterno = apMaterno;
            this.Nombre = nombre;
            this.Sexo = sexo;
            this.CodApoderado = codApoderado;
            this.FechaNacimiento = fechaNacimiento;
            this.Foto = foto;
        }
    }
}
