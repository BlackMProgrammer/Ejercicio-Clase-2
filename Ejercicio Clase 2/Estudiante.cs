using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ejercicio_Clase_2
{
    class Estudiante
    {
        private string _nombre;
        private int _nota1;
        private int _nota2;
        private int _nota3;
        private int _promedio;

        public Estudiante(string _nombre, int _nota1, int _nota2, int _nota3) 
        {
            this._nombre = _nombre;
            this._nota1 = _nota1;
            this._nota2 = _nota2;
            this._nota3 = _nota3;
            if (_nota1 > 100 || _nota2 > 100 || _nota3 > 100)
            {
                Console.WriteLine("La nota no puede ser mayor a 100");
            }
        }

        public int promedio() {

            _promedio = (_nota1 + _nota2 + _nota3) / 3;
            Console.WriteLine("Su promedio es de :{0}",_promedio);
            return _promedio;
        }
    }
}
