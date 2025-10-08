

using Exe_Interface;

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();


ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();

