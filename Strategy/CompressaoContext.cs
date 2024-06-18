namespace Strategy
{
    public class CompressaoContext
    {
        private ICompressao _compressao;

        public CompressaoContext(ICompressao compressao)
        {
            _compressao = compressao;      
        }

        public void DefineStrategy(ICompressao compressao)
        {
            _compressao = compressao;
        }

        public void CriarArquivoCompactado(string nomeArquivo)
        {
            _compressao.ComprimirArquivo(nomeArquivo); 
        }
    }
}
