namespace Model
{
    public class Informacion
    {
        private int idApp;
        private string sistema, dueno, direccion, correo, telefono, imagen;

        public string Sistema { get => sistema; set => sistema = value; }
        public string Dueno { get => dueno; set => dueno = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public int IdApp { get => idApp; set => idApp = value; }

        public Informacion()
        {
            IdApp = 0;
            sistema = "";
            dueno = "";
            direccion = "";
            correo = "";
            telefono = "";
            imagen = "";
        }
    }
}