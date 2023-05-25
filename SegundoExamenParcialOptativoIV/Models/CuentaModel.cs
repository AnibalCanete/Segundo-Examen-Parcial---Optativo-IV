namespace SegundoExamenParcialOptativoIV.Models
{
    public class CuentaModel
    {
        public int Id { get; set; }
        public string NombreCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaldo { get; set; }
        public double LimiteTransferencia { get; set; }
        public string Estado { get; set; }

    }
}
