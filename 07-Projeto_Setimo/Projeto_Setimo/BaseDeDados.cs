using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Setimo
{
    internal class BaseDeDados
    {
        private List<CadastroPessoa> listaDePessoas;

        public void AdicionarPessoa(CadastroPessoa cadastroPessoa)
        {
            listaDePessoas.Add(cadastroPessoa);
        }
        public List<CadastroPessoa> PesquisaPessoaPorDoc(string pNumeroDeDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDeDocumento).ToList();
            if(listaDePessoasTemp.Count > 0)
            {
                return listaDePessoasTemp;
            }
            else
            {
                return null;
            }
        }
        public List<CadastroPessoa> RemoverPessoaPorDoc(string pNumeroDoDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDoDocumento).ToList();
            if (listaDePessoasTemp.Count > 0)
            {
                foreach(CadastroPessoa pessoa in listaDePessoasTemp)
                {
                    listaDePessoas.Remove(pessoa);
                }
                return listaDePessoasTemp;
            }
            else
            {
                return null;
            }
        } 
        public BaseDeDados()
        {
            listaDePessoas = new List<CadastroPessoa>();
        }
    }
}
