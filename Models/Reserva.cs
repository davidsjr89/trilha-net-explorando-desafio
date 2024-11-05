namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("O numero de hospedes excedeu a capacidade limite da suite;");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            if(Hospedes == null) return 0;

            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (Hospedes == null) return 0;

            decimal valor = DiasReservados * Suite.ValorDiaria;
            
            if (DiasReservados >=  10)
                return valor / 90 ;

            return valor;
        }
    }
}