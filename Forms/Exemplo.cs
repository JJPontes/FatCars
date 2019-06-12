using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
	public class Exemplo
	{
		public Exemplo()
		{
		}

		public Exemplo(string nome, string email, string rG, string cPF, string nascimento, string profissao, string cEP, string rua, string numero, string complemento, string bairro, string cidade, string uF, string telRes, string telCom, string telCel)
		{
			Nome = nome;
			Email = email;
			RG = rG;
			CPF = cPF;
			Nascimento = nascimento;
			Profissao = profissao;
			CEP = cEP;
			Rua = rua;
			Numero = numero;
			Complemento = complemento;
			Bairro = bairro;
			Cidade = cidade;
			UF = uF;
			TelRes = telRes;
			TelCom = telCom;
			TelCel = telCel;
		}

		public string Nome { get; set; }
		public string Email { get; set; }
		public string RG { get; set; }
		public string CPF { get; set; }
		public string Nascimento { get; set; }
		public string Profissao { get; set; }
		public string CEP { get; set; }
		public string Rua { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string UF { get; set; }
		public string TelRes { get; set; }
		public string TelCom { get; set; }
		public string TelCel { get; set; }

		
	}

	
}
