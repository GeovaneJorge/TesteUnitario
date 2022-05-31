using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Shared;
using System;

namespace UnitTestPradrao
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestarIdadeMaior18()
		{
			int idade = 18;
			bool resultado = Helper.VerificarIdadeRisco(idade);
			Assert.IsTrue(resultado);
		}

		[TestMethod]
		public void TestarNomeRisco()
		{
			string nome = "Geovane";
			bool resultado = Helper.VerificarNomeDeRisco(nome);
			Assert.IsTrue(resultado);
		}
	}
}
