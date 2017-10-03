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

            var aplicacional = new Category(incidente, "Aplicacional", "Incidente com aplicação");
            var equipamento = new Category(incidente, "Equipamento", "Incidente com equipamento");
            var rede = new Category(incidente, "Rede", "Incidente com rede");
            var sistemas = new Category(incidente, "Sistemas", "Incidente relacionado com sistemas");

            var logins = new Category(pedido, "Pedido", "Pedido de logins aplicacionais");
            var dadosestatisticos = new Category(pedido, "Dados estatísticos", "Pedido de dados estatísticos");
            var informacao = new Category(pedido, "Informação geral", "Pedido de informação");
            var instrucoes = new Category(pedido, "Instruções", "Pedido de instruções");

            var hcis = new Category(aplicacional, "HCis", "Aplicação HCis");
            var sinus = new Category(aplicacional, "SINUS", "Aplicação SINUS");
            var sclinico = new Category(aplicacional, "Sclinico", "Aplicação sclinico hospitalar");
            var sclinicocsp = new Category(aplicacional, "Sclinico CSP", "Aplicação sclinico cuidados de saúde primários");
            var sonho = new Category(aplicacional, "SONHO", "Aplicação sonho");

            var maufuncionamento = new Category(equipamento, "Mau funcionamento de equipamento", "Mau funcionamento de equipamento");
            var avaria = new Category(equipamento, "Avaria de equipamento", "Avaria de equipamento");
            var desaparecimento = new Category(equipamento, "Desaparecimento de equipamento", "Desaparecimento de equipamento");

            var acessorede = new Category(rede, "Acesso à rede", "Problemas no acesso à rede");
            var internet = new Category(rede, "Internet", "Problemas no acesso à internet");
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

            var maufuncionamentoleitorcartoes = new Category(maufuncionamento, "Leitor de cartões", "Mau funcionamento de leitor de cartões");
            var avarialeitorcartoes = new Category(avaria, "Leitor de cartões", "Avaria de leitor de cartões");
            var desaparecimentoleitorcartoes = new Category(desaparecimento, "Leitor de cartões", "Desaparecimento de leitor de cartões");

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
                new Service("Arquivo Clínico"),
                new Service("Auditoria Interna"),
                new Service("Bloco de Partos"),
                new Service("Bloco Operatório"),
                new Service("Call-Center"),
                new Service("Centro de Diagnóstico Pneumológico"),
                new Service("Centro de Ensaios Clínicos"),
                new Service("Centro de Formação"),
                new Service("Cirurgia de Ambulatório"),
                new Service("Clínica dos Trabalhadores Portuários do Douro e Leixões"),
                new Service("Conselho de Administração"),
                new Service("Consulta Externa"),
                new Service("Consulta Externa de Pediatria"),
                new Service("Cozinha"),
                new Service("Departamento de Gestão de Recursos Humanos e Gestão Documental"),
                new Service("Direção Clínica"),
                new Service("Direção de Enfermagem"),
                new Service("Equipa de Gestão de Altas"),
                new Service("Equipa de Gestão de Camas e Altas"),
                new Service("Equipa Doente Crónico Complexo"),
                new Service("Exames Especiais"),
                new Service("Gabinete Apoio ao ACES"),
                new Service("Gabinete de Codificação"),
                new Service("Gabinete de Comunicação e Relações Públicas"),
                new Service("Gabinete de Contratualização"),
                new Service("Gabinete de Higiene e Segurança"),
                new Service("Gabinete de Investigação"),
                new Service("Gabinete de Qualidade"),
                new Service("Gabinete de Saúde Ocupacional"),
                new Service("Gabinete de Transportes"),
                new Service("Gabinete do Cidadão"),
                new Service("Gabinete Jurídico"),
                new Service("Hospital de Dia"),
                new Service("Internato Médico"),
                new Service("Medicina Física e de Reabilitação"),
                new Service("Privada I – Clínica da Senhora da Hora"),
                new Service("Serviço de Anatomia Patológica"),
                new Service("Serviço de Anestesiologia"),
                new Service("Serviço de Biblioteca"),
                new Service("Serviço de Cardiologia"),
                new Service("Serviço de Cirurgia Geral"),
                new Service("Serviço de Compras e Logística"),
                new Service("Serviço de Cuidados Intermédios Cirúrgicos"),
                new Service("Serviço de Dermatologia"),
                new Service("Serviço de Endocrinologia"),
                new Service("Serviço de Esterilização Central"),
                new Service("Serviço de Gastroenterologia"),
                new Service("Serviço de Ginecologia"),
                new Service("Serviço de Obstetrícia"),
                new Service("Serviço de Hemoterapia e Hematologia Clínica"),
                new Service("Serviço de Imagiologia"),
                new Service("Serviço de Infeciologia"),
                new Service("Serviço de Informática"),
                new Service("Serviço de Instalações e Equipamentos"),
                new Service("Serviço de Medicina Intensiva"),
                new Service("Serviço de Medicina Interna"),
                new Service("Serviço de Neonatologia"),
                new Service("Serviço de Neurocirurgia"),
                new Service("Serviço de Neurologia"),
                new Service("Serviço de Nutrição"),
                new Service("Serviço de Oftalmologia"),
                new Service("Serviço de Oncologia"),
                new Service("Serviço de Ortopedia"),
                new Service("Serviço de Otorrinolaringologia"),
                new Service("Serviço de Patologia Clínica"),
                new Service("Serviço de Pediatria"),
                new Service("Serviço de Planeamento e Controlo de Gestão"),
                new Service("Serviço de Pneumologia"),
                new Service("Serviço de Psicologia"),
                new Service("Serviço de Psiquiatria"),
                new Service("Serviço de Urgência"),
                new Service("Serviço de Urologia"),
                new Service("Serviço Social"),
                new Service("Serviços Farmacêuticos"),
                new Service("Serviços Financeiros"),
                new Service("Serviços Hoteleiros"),
                new Service("Supervisão Enfermagem"),
                new Service("UCC de Leça da Palmeira"),
                new Service("UCC de Matosinhos"),
                new Service("UCC de São Mamede"),
                new Service("UCC de Senhora da Hora"),
                new Service("UCE de Senhora da Hora"),
                new Service("UCSP de Leça da Palmeira"),
                new Service("UCSP de Matosinhos"),
                new Service("UCSP de Santa Cruz do Bispo"),
                new Service("UCSP de São Mamede de Infesta"),
                new Service("UCSP de Senhora da Hora"),
                new Service("UHGIC"),
                new Service("Unidade de Cirurgia B"),
                new Service("Unidade de Cirurgia C"),
                new Service("Unidade de Cirurgia I"),
                new Service("Unidade de Cirurgia Plástica"),
                new Service("Unidade de Convalescença"),
                new Service("Unidade de Cuidados Intermédios Médicos"),
                new Service("Unidade de Cuidados Intermédios Polivalente"),
                new Service("Unidade de Cuidados Paliativos"),
                new Service("Unidade de Dor Crónica"),
                new Service("Unidade de Endocrinologia Pediátrica"),
                new Service("Unidade de Grávidas de Risco"),
                new Service("Unidade de Hipertensão Arterial e Risco Cardiovascular"),
                new Service("Unidade de Imunoalergologia"),
                new Service("Unidade de Imunoalergologia Pediátrica"),
                new Service("Unidade de Medicina E"),
                new Service("Unidade de Medicina D"),
                new Service("Unidade de Medicina F"),
                new Service("Unidade de Medicina G"),
                new Service("Unidade de Medicina Hiperbárica"),
                new Service("Unidade de Medicina M"),
                new Service("Unidade de Nefrologia"),
                new Service("Unidade de Neuropediatria e Desenvolvimento"),
                new Service("Unidade de Neuroradiologia"),
                new Service("Unidade de Radiologia"),
                new Service("Unidade de Saúde pública"),
                new Service("USF Caravela"),
                new Service("USF Custóias"),
                new Service("USF Dunas"),
                new Service("USF Horizonte"),
                new Service("USF Infesta"),
                new Service("USF Lagoa"),
                new Service("USF Leça"),
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
                new Origin("Contacto telefónico"),
                new Origin("E-mail"),
                new Origin("Aplicação")
            );
        }*/

        /*private void SeedImpacts(STICketContext context)
        {
            context.Impacts.AddOrUpdate(
                new Impact("Utilizador", 2),
                new Impact("Vários utilizadores", 3),
                new Impact("Serviço", 4),
                new Impact("Empresa", 5)
            );
        }*/
    }
}
