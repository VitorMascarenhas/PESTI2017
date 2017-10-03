namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using Domain.Entities.Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PlataformaRPHD.Infrastructure.Data.STICketContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(STICketContext context)
        {
            //SeedCategories(context);
            //SeedServices(context);
            //SeedOrigins(context);
            //SeedImpacts(context);
        }

        /*private void SeedCategories(STICketContext context)
        {
            var incidente = new Category(null, "Incidente", "Registo de um incidente");
            var pedido = new Category(null, "Pedido", "Registo de um pedido");

            var aplicacional = new Category(incidente, "Aplicacional", "Incidente com aplica��o");
            var equipamento = new Category(incidente, "Equipamento", "Incidente com equipamento");
            var rede = new Category(incidente, "Rede", "Incidente com rede");
            var sistemas = new Category(incidente, "Sistemas", "Incidente relacionado com sistemas");

            var logins = new Category(pedido, "Pedido", "Pedido de logins aplicacionais");
            var dadosestatisticos = new Category(pedido, "Dados estat�sticos", "Pedido de dados estat�sticos");
            var informacao = new Category(pedido, "Informa��o geral", "Pedido de informa��o");
            var instrucoes = new Category(pedido, "Instru��es", "Pedido de instru��es");

            var hcis = new Category(aplicacional, "HCis", "Aplica��o HCis");
            var sinus = new Category(aplicacional, "SINUS", "Aplica��o SINUS");
            var sclinico = new Category(aplicacional, "Sclinico", "Aplica��o sclinico hospitalar");
            var sclinicocsp = new Category(aplicacional, "Sclinico CSP", "Aplica��o sclinico cuidados de sa�de prim�rios");
            var sonho = new Category(aplicacional, "SONHO", "Aplica��o sonho");

            var maufuncionamento = new Category(equipamento, "Mau funcionamento de equipamento", "Mau funcionamento de equipamento");
            var avaria = new Category(equipamento, "Avaria de equipamento", "Avaria de equipamento");
            var desaparecimento = new Category(equipamento, "Desaparecimento de equipamento", "Desaparecimento de equipamento");

            var acessorede = new Category(rede, "Acesso � rede", "Problemas no acesso � rede");
            var internet = new Category(rede, "Internet", "Problemas no acesso � internet");
            var mail = new Category(rede, "Mail", "Problemas relacionados com e-mail");

            var software = new Category(sistemas, "Sistema operativo", "Problemas relacionados com o sistema operativo");

            var maufuncionamentorato = new Category(maufuncionamento, "Rato", "Mau funcionamento de raro");
            var avariarato = new Category(avaria, "Rato", "Avaria de rato");
            var desaparecimentorato = new Category(desaparecimento, "Rato", "Desaparecimento de rato");

            var maufuncionamentoteclado = new Category(maufuncionamento, "Teclado", "Mau funcionamento de Teclado");
            var avariateclado = new Category(avaria, "Teclado", "Avaria de teclado");
            var desaparecimentoteclado = new Category(desaparecimento, "Teclado", "Desaparecimento de teclado");

            var maufuncionamentomonitor = new Category(maufuncionamento, "Monitor", "Mau funcionamento de monitor");
            var avariamonitor = new Category(avaria, "Monitor", "Avaria de monitor");
            var desaparecimentomonitor = new Category(desaparecimento, "Monitor", "Desaparecimento de monitor");

            var maufuncionamentoimpressora = new Category(maufuncionamento, "Impressora", "Mau funcionamento de impressora");
            var avariaimpressora = new Category(avaria, "Impressora", "Avaria de impressora");
            var desaparecimentoimpressora = new Category(desaparecimento, "Impressora", "Desaparecimento de impressora");

            var maufuncionamentoleitorcartoes = new Category(maufuncionamento, "Leitor de cart�es", "Mau funcionamento de leitor de cart�es");
            var avarialeitorcartoes = new Category(avaria, "Leitor de cart�es", "Avaria de leitor de cart�es");
            var desaparecimentoleitorcartoes = new Category(desaparecimento, "Leitor de cart�es", "Desaparecimento de leitor de cart�es");

            //------------
            context.Categories.AddOrUpdate(incidente);
            context.Categories.AddOrUpdate(pedido);


            context.Categories.AddOrUpdate(aplicacional);
            context.Categories.AddOrUpdate(equipamento);
            context.Categories.AddOrUpdate(rede);
            context.Categories.AddOrUpdate(sistemas);

            context.Categories.AddOrUpdate(logins);
            context.Categories.AddOrUpdate(dadosestatisticos);
            context.Categories.AddOrUpdate(informacao);
            context.Categories.AddOrUpdate(instrucoes);

            context.Categories.AddOrUpdate(hcis);
            context.Categories.AddOrUpdate(sinus);
            context.Categories.AddOrUpdate(sclinico);
            context.Categories.AddOrUpdate(sclinicocsp);
            context.Categories.AddOrUpdate(sonho);

            context.Categories.AddOrUpdate(maufuncionamento);
            context.Categories.AddOrUpdate(avaria);
            context.Categories.AddOrUpdate(desaparecimento);

            context.Categories.AddOrUpdate(acessorede);
            context.Categories.AddOrUpdate(internet);
            context.Categories.AddOrUpdate(mail);

            context.Categories.AddOrUpdate(software);

            context.Categories.AddOrUpdate(maufuncionamentorato);
            context.Categories.AddOrUpdate(avariarato);
            context.Categories.AddOrUpdate(desaparecimentorato);

            context.Categories.AddOrUpdate(maufuncionamentoteclado);
            context.Categories.AddOrUpdate(avariateclado);
            context.Categories.AddOrUpdate(desaparecimentoteclado);

            context.Categories.AddOrUpdate(maufuncionamentomonitor);
            context.Categories.AddOrUpdate(avariamonitor);
            context.Categories.AddOrUpdate(desaparecimentomonitor);

            context.Categories.AddOrUpdate(maufuncionamentoimpressora);
            context.Categories.AddOrUpdate(avariaimpressora);
            context.Categories.AddOrUpdate(desaparecimentoimpressora);

            context.Categories.AddOrUpdate(maufuncionamentoleitorcartoes);
            context.Categories.AddOrUpdate(avarialeitorcartoes);
            context.Categories.AddOrUpdate(desaparecimentoleitorcartoes);
        }*/

        /*private void SeedServices(STICketContext context)
        {
            context.Services.AddOrUpdate(
                new Service("Arquivo Cl�nico"),
                new Service("Auditoria Interna"),
                new Service("Bloco de Partos"),
                new Service("Bloco Operat�rio"),
                new Service("Call-Center"),
                new Service("Centro de Diagn�stico Pneumol�gico"),
                new Service("Centro de Ensaios Cl�nicos"),
                new Service("Centro de Forma��o"),
                new Service("Cirurgia de Ambulat�rio"),
                new Service("Cl�nica dos Trabalhadores Portu�rios do Douro e Leix�es"),
                new Service("Conselho de Administra��o"),
                new Service("Consulta Externa"),
                new Service("Consulta Externa de Pediatria"),
                new Service("Cozinha"),
                new Service("Departamento de Gest�o de Recursos Humanos e Gest�o Documental"),
                new Service("Dire��o Cl�nica"),
                new Service("Dire��o de Enfermagem"),
                new Service("Equipa de Gest�o de Altas"),
                new Service("Equipa de Gest�o de Camas e Altas"),
                new Service("Equipa Doente Cr�nico Complexo"),
                new Service("Exames Especiais"),
                new Service("Gabinete Apoio ao ACES"),
                new Service("Gabinete de Codifica��o"),
                new Service("Gabinete de Comunica��o e Rela��es P�blicas"),
                new Service("Gabinete de Contratualiza��o"),
                new Service("Gabinete de Higiene e Seguran�a"),
                new Service("Gabinete de Investiga��o"),
                new Service("Gabinete de Qualidade"),
                new Service("Gabinete de Sa�de Ocupacional"),
                new Service("Gabinete de Transportes"),
                new Service("Gabinete do Cidad�o"),
                new Service("Gabinete Jur�dico"),
                new Service("Hospital de Dia"),
                new Service("Internato M�dico"),
                new Service("Medicina F�sica e de Reabilita��o"),
                new Service("Privada I � Cl�nica da Senhora da Hora"),
                new Service("Servi�o de Anatomia Patol�gica"),
                new Service("Servi�o de Anestesiologia"),
                new Service("Servi�o de Biblioteca"),
                new Service("Servi�o de Cardiologia"),
                new Service("Servi�o de Cirurgia Geral"),
                new Service("Servi�o de Compras e Log�stica"),
                new Service("Servi�o de Cuidados Interm�dios Cir�rgicos"),
                new Service("Servi�o de Dermatologia"),
                new Service("Servi�o de Endocrinologia"),
                new Service("Servi�o de Esteriliza��o Central"),
                new Service("Servi�o de Gastroenterologia"),
                new Service("Servi�o de Ginecologia"),
                new Service("Servi�o de Obstetr�cia"),
                new Service("Servi�o de Hemoterapia e Hematologia Cl�nica"),
                new Service("Servi�o de Imagiologia"),
                new Service("Servi�o de Infeciologia"),
                new Service("Servi�o de Inform�tica"),
                new Service("Servi�o de Instala��es e Equipamentos"),
                new Service("Servi�o de Medicina Intensiva"),
                new Service("Servi�o de Medicina Interna"),
                new Service("Servi�o de Neonatologia"),
                new Service("Servi�o de Neurocirurgia"),
                new Service("Servi�o de Neurologia"),
                new Service("Servi�o de Nutri��o"),
                new Service("Servi�o de Oftalmologia"),
                new Service("Servi�o de Oncologia"),
                new Service("Servi�o de Ortopedia"),
                new Service("Servi�o de Otorrinolaringologia"),
                new Service("Servi�o de Patologia Cl�nica"),
                new Service("Servi�o de Pediatria"),
                new Service("Servi�o de Planeamento e Controlo de Gest�o"),
                new Service("Servi�o de Pneumologia"),
                new Service("Servi�o de Psicologia"),
                new Service("Servi�o de Psiquiatria"),
                new Service("Servi�o de Urg�ncia"),
                new Service("Servi�o de Urologia"),
                new Service("Servi�o Social"),
                new Service("Servi�os Farmac�uticos"),
                new Service("Servi�os Financeiros"),
                new Service("Servi�os Hoteleiros"),
                new Service("Supervis�o Enfermagem"),
                new Service("UCC de Le�a da Palmeira"),
                new Service("UCC de Matosinhos"),
                new Service("UCC de S�o Mamede"),
                new Service("UCC de Senhora da Hora"),
                new Service("UCE de Senhora da Hora"),
                new Service("UCSP de Le�a da Palmeira"),
                new Service("UCSP de Matosinhos"),
                new Service("UCSP de Santa Cruz do Bispo"),
                new Service("UCSP de S�o Mamede de Infesta"),
                new Service("UCSP de Senhora da Hora"),
                new Service("UHGIC"),
                new Service("Unidade de Cirurgia B"),
                new Service("Unidade de Cirurgia C"),
                new Service("Unidade de Cirurgia I"),
                new Service("Unidade de Cirurgia Pl�stica"),
                new Service("Unidade de Convalescen�a"),
                new Service("Unidade de Cuidados Interm�dios M�dicos"),
                new Service("Unidade de Cuidados Interm�dios Polivalente"),
                new Service("Unidade de Cuidados Paliativos"),
                new Service("Unidade de Dor Cr�nica"),
                new Service("Unidade de Endocrinologia Pedi�trica"),
                new Service("Unidade de Gr�vidas de Risco"),
                new Service("Unidade de Hipertens�o Arterial e Risco Cardiovascular"),
                new Service("Unidade de Imunoalergologia"),
                new Service("Unidade de Imunoalergologia Pedi�trica"),
                new Service("Unidade de Medicina E"),
                new Service("Unidade de Medicina D"),
                new Service("Unidade de Medicina F"),
                new Service("Unidade de Medicina G"),
                new Service("Unidade de Medicina Hiperb�rica"),
                new Service("Unidade de Medicina M"),
                new Service("Unidade de Nefrologia"),
                new Service("Unidade de Neuropediatria e Desenvolvimento"),
                new Service("Unidade de Neuroradiologia"),
                new Service("Unidade de Radiologia"),
                new Service("Unidade de Sa�de p�blica"),
                new Service("USF Caravela"),
                new Service("USF Cust�ias"),
                new Service("USF Dunas"),
                new Service("USF Horizonte"),
                new Service("USF Infesta"),
                new Service("USF Lagoa"),
                new Service("USF Le�a"),
                new Service("USF Maresia"),
                new Service("USF Oceanos"),
                new Service("USF Porta do Sol"),
                new Service("USF Progresso"),
                new Service("VMER")
            );
        }*/

        /*private void SeedOrigins(STICketContext context)
        {
            context.Origins.AddOrUpdate(
                new Origin("Presencial"),
                new Origin("Contacto telef�nico"),
                new Origin("E-mail"),
                new Origin("Aplica��o")
            );
        }*/

        /*private void SeedImpacts(STICketContext context)
        {
            context.Impacts.AddOrUpdate(
                new Impact("Utilizador", 2),
                new Impact("V�rios utilizadores", 3),
                new Impact("Servi�o", 4),
                new Impact("Empresa", 5)
            );
        }*/
    }
}
