namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
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
            //SeedTopics(context);
            //SeedServices(context);
        }

        /*private void SeedCategories(STICketContext context)
        {
            context.Categories.AddOrUpdate(
                //primeiro nivel
                new Category("Incidente", "Registo de um incidente"),
                new Category("Pedido", "Registo de um pedido"),
                //segundo nível
                new Category("Aplicacional", "Problema com aplicação"),
                new Category("Equipamento", "Problema com equipamento"),
                new Category("Rede/Mail/Internet", "Problema com Rede, mail ou internet"),
                new Category("Logins aplicacionais", "Logins aplicacionais"),
                new Category("informação/dúvidas", "informação/dúvidas"),
                //terceiro nível
                new Category("Hcis", "Hcis"),
                new Category("Siima", "Siima"),
                new Category("Sinus", "Sinus"),
                new Category("Sclinico", "Sclinico"),
                new Category("Sclinico CSP", "Sclinico CSP"),
                new Category("Sonho", "Sonho"),
                //quarto nível
                new Category("Rato", "Rato"),
                new Category("Teclado", "Teclado"),
                new Category("Monitor", "Monitor"),
                new Category("Leitor de cartões", "Leitor de cartões"),
                new Category("Avaria de equipamento", "Avaria de equipamento"),
                new Category("Mau funcionamento de equipamento", "funcionamento de equipamento"),
                new Category("Substituição de equipamento", "Substituição de equipamento"),
                new Category("Desaparecimento de equipamento", "Desaparecimento de equipamento"),
                new Category("Movimentação de equipamento", "Movimentação de equipamento"),
                new Category("Adicionar/Modificar/Eliminar registos", "Adicionar, modificar ou eliminar registos aplicacionais"),
                new Category("Erro na aplicação", "Erro na aplicação")
            );
        }*/

        /*public void SeedTopics(STICketContext context)
        {
            context.Topics.AddOrUpdate(
                new Topic(new Category("Incidente", "Registo de um incidente"), new Category("Aplicacional", "Problema com aplicação")),
                new Topic(new Category("Incidente", "Registo de um incidente"), new Category("Equipamento", "Problema com equipamento")),
                new Topic(new Category("Incidente", "Registo de um incidente"), new Category("Rede/Mail/Internet", "Problema com Rede, mail ou internet")),

                new Topic(new Category("Pedido", "Registo de um pedido"), new Category("Logins aplicacionais", "Logins aplicacionais")),
                new Topic(new Category("Pedido", "Registo de um pedido"), new Category("informação/dúvidas", "informação/dúvidas")),

                new Topic(new Category("Aplicacional", "Problema com aplicação"), new Category("Hcis", "Hcis")),
                new Topic(new Category("Aplicacional", "Problema com aplicação"), new Category("Siima", "Siima")),
                new Topic(new Category("Aplicacional", "Problema com aplicação"), new Category("Sinus", "Sinus")),
                new Topic(new Category("Aplicacional", "Problema com aplicação"), new Category("Sclinico", "Sclinico")),
                new Topic(new Category("Aplicacional", "Problema com aplicação"), new Category("Sclinico CSP", "Sclinico CSP")),
                new Topic(new Category("Aplicacional", "Problema com aplicação"), new Category("Sonho", "Sonho")),

                new Topic(new Category("Logins aplicacionais", "Logins aplicacionais"), new Category("Hcis", "Hcis")),
                new Topic(new Category("Logins aplicacionais", "Logins aplicacionais"), new Category("Siima", "Siima")),
                new Topic(new Category("Logins aplicacionais", "Logins aplicacionais"), new Category("Sinus", "Sinus")),
                new Topic(new Category("Logins aplicacionais", "Logins aplicacionais"), new Category("Sclinico", "Sclinico")),
                new Topic(new Category("Logins aplicacionais", "Logins aplicacionais"), new Category("Sclinico CSP", "Sclinico CSP")),
                new Topic(new Category("Logins aplicacionais", "Logins aplicacionais"), new Category("Sonho", "Sonho")),
                new Topic(new Category("informação/dúvidas", "informação/dúvidas"), new Category("Aplicacional", "Problema com aplicação")),
                new Topic(new Category("informação/dúvidas", "informação/dúvidas"), new Category("Equipamento", "Problema com equipamento")),
                new Topic(new Category("informação/dúvidas", "informação/dúvidas"), new Category("Rede/Mail/Internet", "Problema com Rede, mail ou internet")),
                new Topic(new Category("Equipamento", "Problema com equipamento"), new Category("Avaria de equipamento", "Avaria de equipamento")),
                new Topic(new Category("Equipamento", "Problema com equipamento"), new Category("Mau funcionamento de equipamento", "Mau funcionamento de equipamento")),
                new Topic(new Category("Equipamento", "Problema com equipamento"), new Category("Substituição de equipamento", "Substituição de equipamento")),
                new Topic(new Category("Equipamento", "Problema com equipamento"), new Category("Desaparecimento de equipamento", "Desaparecimento de equipamento")),
                new Topic(new Category("Equipamento", "Problema com equipamento"), new Category("Movimentação de equipamento", "Movimentação de equipamento")),
                new Topic(new Category("Avaria de equipamento", "Avaria de equipamento"), new Category("Rato", "Rato")),
                new Topic(new Category("Avaria de equipamento", "Avaria de equipamento"), new Category("Teclado", "Teclado")),
                new Topic(new Category("Avaria de equipamento", "Avaria de equipamento"), new Category("Monitor", "Monitor")),
                new Topic(new Category("Avaria de equipamento", "Avaria de equipamento"), new Category("Leitor de cartões", "Leitor de cartões")),
                new Topic(new Category("Mau funcionamento de equipamento", "funcionamento de equipamento"), new Category("Rato", "Rato")), 
                new Topic(new Category("Mau funcionamento de equipamento", "funcionamento de equipamento"), new Category("Teclado", "Teclado")),
                new Topic(new Category("Mau funcionamento de equipamento", "funcionamento de equipamento"), new Category("Monitor", "Monitor")),
                new Topic(new Category("Mau funcionamento de equipamento", "funcionamento de equipamento"), new Category("Leitor de cartões", "Leitor de cartões")),
                new Topic(new Category("Substituição de equipamento", "Substituição de equipamento"), new Category("Rato", "Rato")),
                new Topic(new Category("Substituição de equipamento", "Substituição de equipamento"), new Category("Teclado", "Teclado")),
                new Topic(new Category("Substituição de equipamento", "Substituição de equipamento"), new Category("Monitor", "Monitor")),
                new Topic(new Category("Substituição de equipamento", "Substituição de equipamento"), new Category("Leitor de cartões", "Leitor de cartões")),
                new Topic(new Category("Desaparecimento de equipamento", "Desaparecimento de equipamento"), new Category("Rato", "Rato")),
                new Topic(new Category("Desaparecimento de equipamento", "Desaparecimento de equipamento"), new Category("Teclado", "Teclado")),
                new Topic(new Category("Desaparecimento de equipamento", "Desaparecimento de equipamento"), new Category("Monitor", "Monitor")),
                new Topic(new Category("Desaparecimento de equipamento", "Desaparecimento de equipamento"), new Category("Leitor de cartões", "Leitor de cartões")),
                new Topic(new Category("Movimentação de equipamento", "Movimentação de equipamento"), new Category("Rato", "Rato")),
                new Topic(new Category("Movimentação de equipamento", "Movimentação de equipamento"), new Category("Teclado", "Teclado")),
                new Topic(new Category("Movimentação de equipamento", "Movimentação de equipamento"), new Category("Monitor", "Monitor")),
                new Topic(new Category("Movimentação de equipamento", "Movimentação de equipamento"), new Category("Leitor de cartões", "Leitor de cartões"))
            );
        }*/

        /*private void SeedServices(STICketContext context)
        {
            context.Services.AddOrUpdate(
                new Service("Arquivo Clínico"),
                new Service("Auditoria Interna"),
                new Service("Bloco de Partos"),
                new Service("Bloco Operatório"),
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
    }
}

