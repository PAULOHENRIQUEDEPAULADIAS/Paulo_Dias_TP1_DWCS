using System;
using System.Threading;


namespace Paulo_Dias_TP1
{
    class DownloadManager
    {

        public event EventHandler DownloadCompleted;

        public void IniciarDownload()
        {
            Console.WriteLine("Iniciando o download...");
            Thread.Sleep(3000);
            Console.WriteLine("Download finalizado internamente!");

            OnDownloadCompleted();
        }

        protected virtual void OnDownloadCompleted()
        {
            DownloadCompleted?.Invoke(this, EventArgs.Empty);
        }

        public void AoFinalizarDownload(object sender, EventArgs e)
        {
            Console.WriteLine("O download foi concluído com sucesso!");
        }
    }
}
