﻿using System.Text;

namespace ClassLibraryTest
{
    class Trailler
    {
        private const string tipoRegistro = "9";

        private string branco = new string(' ', 393);

        public StringBuilder GetTrailler(Trailler stringTrailler, string numSequencial)
        {
            StringBuilder trailler = new StringBuilder(400);

            trailler.Insert(0, tipoRegistro);
            trailler.Insert(1, stringTrailler.branco);
            trailler.Insert(394, numSequencial);

            return trailler;
        }
    }
}
