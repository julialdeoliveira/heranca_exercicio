namespace Herança
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validate v = new Validate();
            v.Validar(new Pessoa());
            v.Validar(new PessoaFisica());
            v.Validar(new PessoaJuridica());
        }
    }
    class Validate
    {
        public void Validar (Pessoa p)
        {
            if(p.Nome == "")
            {
                throw new Exception("Erro");
            }
            if(p is PessoaFisica)
            {
                PessoaFisica pf = (PessoaFisica)p;
                if (pf.CPF.Length != 11)
                {
                    throw new Exception("Cpf inválido");
                }
            }
            else
            {
                PessoaJuridica pj = (PessoaJuridica)p;
            }
        }
    }

    class Pessoa
    {
        public int IDNome { get; set; }
        public string Nome { get; set; }

    }
    class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }
    class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public DateTime InicioAtividades { get; set; }
    }
}