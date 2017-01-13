using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NovatecEnergyWeb.Models.MetasViewModels;

namespace NovatecEnergyWeb.Models
{
    public partial class BDNVTContext : DbContext
    {
        public virtual DbSet<_10_MetasCargas> _10_MetasCargas { get; set; }
        public virtual DbSet<Cdtributacao> Cdtributacao { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Cnaes> Cnaes { get; set; }
        public virtual DbSet<CodServiços> CodServiços { get; set; }
        public virtual DbSet<CodVendas> CodVendas { get; set; }
        public virtual DbSet<Condominios> Condominios { get; set; }
        public virtual DbSet<Contas> Contas { get; set; }
        public virtual DbSet<Favorecidos> Favorecidos { get; set; }
        public virtual DbSet<Funcionários> Funcionários { get; set; }
        public virtual DbSet<ItensServ> ItensServ { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<NfeCfop> NfeCfop { get; set; }
        public virtual DbSet<NfeDiretorios> NfeDiretorios { get; set; }
        public virtual DbSet<NfeIbge> NfeIbge { get; set; }
        public virtual DbSet<NfeIbgeUf> NfeIbgeUf { get; set; }
        public virtual DbSet<NfeInfAdicionais> NfeInfAdicionais { get; set; }
        public virtual DbSet<NfeInfCancelamento> NfeInfCancelamento { get; set; }
        public virtual DbSet<NfeInfNotaFiscal> NfeInfNotaFiscal { get; set; }
        public virtual DbSet<NfeInfProdutos> NfeInfProdutos { get; set; }
        public virtual DbSet<NfeParametros> NfeParametros { get; set; }
        public virtual DbSet<NfseNotas> NfseNotas { get; set; }
        public virtual DbSet<NfseParametros> NfseParametros { get; set; }
        public virtual DbSet<Prefeituras> Prefeituras { get; set; }
        public virtual DbSet<Registro> Registro { get; set; }
        public virtual DbSet<Rj11rj45> Rj11rj45 { get; set; }
        public virtual DbSet<TablasGenerales> TablasGenerales { get; set; }
        public virtual DbSet<TblRibbons> TblRibbons { get; set; }
        public virtual DbSet<TblUsuários> TblUsuários { get; set; }
        public virtual DbSet<Tecnicos> Tecnicos { get; set; }
        public virtual DbSet<TiDeletar> TiDeletar { get; set; }
        public virtual DbSet<TipoDeConta> TipoDeConta { get; set; }
        public virtual DbSet<TipoDeDocumento> TipoDeDocumento { get; set; }
        public virtual DbSet<TipoNatOp> TipoNatOp { get; set; }
        public virtual DbSet<TipoNf> TipoNf { get; set; }
        public virtual DbSet<TipoNfregTrib> TipoNfregTrib { get; set; }
        public virtual DbSet<TipoNfserie> TipoNfserie { get; set; }
        public virtual DbSet<TipoNfstatus> TipoNfstatus { get; set; }
        public virtual DbSet<_0000extratos> _0000extratos { get; set; }
        public virtual DbSet<_00Areas> _00Areas { get; set; }
        public virtual DbSet<_00Bairro> _00Bairro { get; set; }
        public virtual DbSet<_00Caminhos> _00Caminhos { get; set; }
        public virtual DbSet<_00Delegação> _00Delegação { get; set; }
        public virtual DbSet<_00Empresa> _00Empresa { get; set; }
        public virtual DbSet<_00Estado> _00Estado { get; set; }
        public virtual DbSet<_00Filial> _00Filial { get; set; }
        public virtual DbSet<_00Localidade> _00Localidade { get; set; }
        public virtual DbSet<_00Logradouro> _00Logradouro { get; set; }
        public virtual DbSet<_00Produtos> _00Produtos { get; set; }
        public virtual DbSet<_00Setores> _00Setores { get; set; }
        public virtual DbSet<_00TabelasItems> _00TabelasItems { get; set; }
        public virtual DbSet<_00TipoLog2> _00TipoLog2 { get; set; }
        public virtual DbSet<_00TipoLogradouro> _00TipoLogradouro { get; set; }
        public virtual DbSet<_00TiposContrato> _00TiposContrato { get; set; }
        public virtual DbSet<_00Zona> _00Zona { get; set; }
        public virtual DbSet<_10BdConta> _10BdConta { get; set; }
        public virtual DbSet<_10Campanha> _10Campanha { get; set; }
        public virtual DbSet<_10CampanhaId> _10CampanhaId { get; set; }
        public virtual DbSet<_10CargasAgendadasId> _10CargasAgendadasId { get; set; }
        public virtual DbSet<_10CargasAgendadasSub> _10CargasAgendadasSub { get; set; }
        public virtual DbSet<_10Certificados> _10Certificados { get; set; }
        public virtual DbSet<_10CertificadosId> _10CertificadosId { get; set; }
        public virtual DbSet<_10CertificadosTemp> _10CertificadosTemp { get; set; }
        public virtual DbSet<_10ClientesCegdetalhesN> _10ClientesCegdetalhesN { get; set; }
        public virtual DbSet<_10ClientesCegobs> _10ClientesCegobs { get; set; }
        public virtual DbSet<_10ClientesCegresponsável> _10ClientesCegresponsável { get; set; }
        public virtual DbSet<_10ClientesCegtemas> _10ClientesCegtemas { get; set; }
        public virtual DbSet<_10ComissoesPgto> _10ComissoesPgto { get; set; }
        public virtual DbSet<_10ComissoesPgtoSub> _10ComissoesPgtoSub { get; set; }
        public virtual DbSet<_10ConsultaZeus> _10ConsultaZeus { get; set; }
        public virtual DbSet<_10ConsultaZeusB> _10ConsultaZeusB { get; set; }
        public virtual DbSet<_10Equipamentos> _10Equipamentos { get; set; }
        public virtual DbSet<_10EquipeVendas> _10EquipeVendas { get; set; }
        public virtual DbSet<_10Metas> _10Metas { get; set; }
        public virtual DbSet<_10OsServiços> _10OsServiços { get; set; }
        public virtual DbSet<_10Osmateriais> _10Osmateriais { get; set; }
        public virtual DbSet<_10Periodo> _10Periodo { get; set; }
        public virtual DbSet<_10PgtoPromos> _10PgtoPromos { get; set; }
        public virtual DbSet<_10PgtoPromosId> _10PgtoPromosId { get; set; }
        public virtual DbSet<_10Precert> _10Precert { get; set; }
        public virtual DbSet<_10PrecertId> _10PrecertId { get; set; }
        public virtual DbSet<_10PrecertTemp> _10PrecertTemp { get; set; }
        public virtual DbSet<_10ProdPgtoId> _10ProdPgtoId { get; set; }
        public virtual DbSet<_10ProdPgtoSub01> _10ProdPgtoSub01 { get; set; }
        public virtual DbSet<_10ProdPgtoSub02> _10ProdPgtoSub02 { get; set; }
        public virtual DbSet<_10Promos> _10Promos { get; set; }
        public virtual DbSet<_10Protocolo> _10Protocolo { get; set; }
        public virtual DbSet<_10ProtocoloId> _10ProtocoloId { get; set; }
        public virtual DbSet<_10ProtocoloTemp> _10ProtocoloTemp { get; set; }
        public virtual DbSet<_10Serviços> _10Serviços { get; set; }
        public virtual DbSet<_10Status> _10Status { get; set; }
        public virtual DbSet<_10StatusB> _10StatusB { get; set; }
        public virtual DbSet<_10TarifaSocial> _10TarifaSocial { get; set; }
        public virtual DbSet<_10TipoProposta> _10TipoProposta { get; set; }
        public virtual DbSet<_10ValorVendas> _10ValorVendas { get; set; }
        public virtual DbSet<_10ValoresOp> _10ValoresOp { get; set; }
        public virtual DbSet<_11CondEstrutura> _11CondEstrutura { get; set; }
        public virtual DbSet<_11CondVisitas> _11CondVisitas { get; set; }
        public virtual DbSet<_11CondVisitasTemp> _11CondVisitasTemp { get; set; }
        public virtual DbSet<_11Condominios> _11Condominios { get; set; }
        public virtual DbSet<_11CondominiosDetalheN> _11CondominiosDetalheN { get; set; }
        public virtual DbSet<_11CondominiosObs> _11CondominiosObs { get; set; }
        public virtual DbSet<_11CondominiosResponsavel> _11CondominiosResponsavel { get; set; }
        public virtual DbSet<_11CondominiosTemas> _11CondominiosTemas { get; set; }
        public virtual DbSet<_11MotivosRej> _11MotivosRej { get; set; }
        public virtual DbSet<_20Agencias> _20Agencias { get; set; }
        public virtual DbSet<_20Contratos> _20Contratos { get; set; }
        public virtual DbSet<_20EntidadesBancarias> _20EntidadesBancarias { get; set; }
        public virtual DbSet<_20EnviosBancos> _20EnviosBancos { get; set; }
        public virtual DbSet<_20EnviosBancosId> _20EnviosBancosId { get; set; }
        public virtual DbSet<_30Anos> _30Anos { get; set; }
        public virtual DbSet<_30Cargos> _30Cargos { get; set; }
        public virtual DbSet<_30CargosB> _30CargosB { get; set; }
        public virtual DbSet<_30Comerciais> _30Comerciais { get; set; }
        public virtual DbSet<_30ComerciaisAreas> _30ComerciaisAreas { get; set; }
        public virtual DbSet<_30Escolaridade> _30Escolaridade { get; set; }
        public virtual DbSet<_30EstadoCivil> _30EstadoCivil { get; set; }
        public virtual DbSet<_30FolhaTipos> _30FolhaTipos { get; set; }
        public virtual DbSet<_30FormaPgtoVtvr> _30FormaPgtoVtvr { get; set; }
        public virtual DbSet<_30Meses> _30Meses { get; set; }
        public virtual DbSet<_30Ponto> _30Ponto { get; set; }
        public virtual DbSet<_30PontoId> _30PontoId { get; set; }
        public virtual DbSet<_30PontoPgto> _30PontoPgto { get; set; }
        public virtual DbSet<_30PontoPgtoId> _30PontoPgtoId { get; set; }
        public virtual DbSet<_30Salarios> _30Salarios { get; set; }
        public virtual DbSet<_30SalariosId> _30SalariosId { get; set; }
        public virtual DbSet<_30SalariosTemp> _30SalariosTemp { get; set; }
        public virtual DbSet<_30SodexoParametros> _30SodexoParametros { get; set; }
        public virtual DbSet<_30TiposContaBancaria> _30TiposContaBancaria { get; set; }
        public virtual DbSet<_30Vtvr> _30Vtvr { get; set; }
        public virtual DbSet<_30Vtvrtipos> _30Vtvrtipos { get; set; }
        public virtual DbSet<_40Centros> _40Centros { get; set; }
        public virtual DbSet<_40Clase> _40Clase { get; set; }
        public virtual DbSet<_40Cotacao> _40Cotacao { get; set; }
        public virtual DbSet<_40CotacaoId> _40CotacaoId { get; set; }
        public virtual DbSet<_40EstoqueMinimo> _40EstoqueMinimo { get; set; }
        public virtual DbSet<_40Familia> _40Familia { get; set; }
        public virtual DbSet<_40Grupo> _40Grupo { get; set; }
        public virtual DbSet<_40Interna> _40Interna { get; set; }
        public virtual DbSet<_40InternaId> _40InternaId { get; set; }
        public virtual DbSet<_40Local> _40Local { get; set; }
        public virtual DbSet<_40Localização> _40Localização { get; set; }
        public virtual DbSet<_40Parceiros> _40Parceiros { get; set; }
        public virtual DbSet<_40Pedidos> _40Pedidos { get; set; }
        public virtual DbSet<_40PedidosId> _40PedidosId { get; set; }
        public virtual DbSet<_40PeticaoTemp> _40PeticaoTemp { get; set; }
        public virtual DbSet<_40Produtos> _40Produtos { get; set; }
        public virtual DbSet<_40Saidas> _40Saidas { get; set; }
        public virtual DbSet<_40SaidasId> _40SaidasId { get; set; }
        public virtual DbSet<_40Unidades> _40Unidades { get; set; }
        public virtual DbSet<_50CroquiCentroContabil> _50CroquiCentroContabil { get; set; }
        public virtual DbSet<_50Croquis> _50Croquis { get; set; }
        public virtual DbSet<_50CroquisImport> _50CroquisImport { get; set; }
        public virtual DbSet<_50CroquisSubImport> _50CroquisSubImport { get; set; }
        public virtual DbSet<_50DiasTrabalho> _50DiasTrabalho { get; set; }
        public virtual DbSet<_50DiasTrabalhoMo> _50DiasTrabalhoMo { get; set; }
        public virtual DbSet<_50DiasTrabalhoObras> _50DiasTrabalhoObras { get; set; }
        public virtual DbSet<_50ItemsRedeRamal> _50ItemsRedeRamal { get; set; }
        public virtual DbSet<_50ItemsTipo> _50ItemsTipo { get; set; }
        public virtual DbSet<_50ItemsValor> _50ItemsValor { get; set; }
        public virtual DbSet<_50LotesPlanoTeste> _50LotesPlanoTeste { get; set; }
        public virtual DbSet<_50LotesPlanoTesteId> _50LotesPlanoTesteId { get; set; }
        public virtual DbSet<_50LotesPvc> _50LotesPvc { get; set; }
        public virtual DbSet<_50Metas> _50Metas { get; set; }
        public virtual DbSet<_50ObrasResponsávelObs> _50ObrasResponsávelObs { get; set; }
        public virtual DbSet<_50OpempreiteirasId> _50OpempreiteirasId { get; set; }
        public virtual DbSet<_50OpempreiteirasSub01> _50OpempreiteirasSub01 { get; set; }
        public virtual DbSet<_50OpempreiteirasSub02> _50OpempreiteirasSub02 { get; set; }
        public virtual DbSet<_50OpproducaoA> _50OpproducaoA { get; set; }
        public virtual DbSet<_50OpproducaoB> _50OpproducaoB { get; set; }
        public virtual DbSet<_50OpproducaoId> _50OpproducaoId { get; set; }
        public virtual DbSet<_50PlanoTesteMat> _50PlanoTesteMat { get; set; }
        public virtual DbSet<_50Precert> _50Precert { get; set; }
        public virtual DbSet<_50PrecertId> _50PrecertId { get; set; }
        public virtual DbSet<_50PrecertTipo> _50PrecertTipo { get; set; }
        public virtual DbSet<_50ProcertAcres> _50ProcertAcres { get; set; }
        public virtual DbSet<_50ProjetoDescricao> _50ProjetoDescricao { get; set; }
        public virtual DbSet<_50ProjetoDesenvolvimento> _50ProjetoDesenvolvimento { get; set; }
        public virtual DbSet<_50ProjetoLicenciamento> _50ProjetoLicenciamento { get; set; }
        public virtual DbSet<_50ProjetoMateriais> _50ProjetoMateriais { get; set; }
        public virtual DbSet<_50ProjetoNatureza> _50ProjetoNatureza { get; set; }
        public virtual DbSet<_50ProjetoServiços> _50ProjetoServiços { get; set; }
        public virtual DbSet<_50ProjetoStatus> _50ProjetoStatus { get; set; }
        public virtual DbSet<_50ProjetoTipo> _50ProjetoTipo { get; set; }
        public virtual DbSet<_50ProjetosMetragem> _50ProjetosMetragem { get; set; }
        public virtual DbSet<_50ProjetosRedeRamalDetalheN> _50ProjetosRedeRamalDetalheN { get; set; }
        public virtual DbSet<_50ProjetosRedeRamalObs> _50ProjetosRedeRamalObs { get; set; }
        public virtual DbSet<_50ProjetosRedeRamalTema> _50ProjetosRedeRamalTema { get; set; }
        public virtual DbSet<_50Tubos> _50Tubos { get; set; }
        public virtual DbSet<_50TubosTipo> _50TubosTipo { get; set; }
        public virtual DbSet<_60CertificacaoEquipamentos> _60CertificacaoEquipamentos { get; set; }
        public virtual DbSet<_60CertificacaoEquipamentosId> _60CertificacaoEquipamentosId { get; set; }
        public virtual DbSet<_60ProdutosGns> _60ProdutosGns { get; set; }
        public virtual DbSet<ClientesWeb> ClientesWeb { get; set; }

        // Unable to generate entity type for table 'dbo.11_CondVisitas2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Teste'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.50_ProjetosRedeRamal'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FuncionáriosTeste'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.20_Historico'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.z_11_Condominios'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Funcionarios'. Please see the warning messages.

        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
             optionsBuilder.UseSqlServer(@"Server=NVTSERVER;DataBase=TESTE2TS;Uid=NVT;Pwd=1;Trusted_Connection=True;");
         }*/

        public BDNVTContext(DbContextOptions<BDNVTContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_10_MetasCargas>().HasKey(c => c.Id);

            modelBuilder.Entity<Cdtributacao>(entity =>
            {
                entity.HasKey(e => e.CdTribut)
                    .HasName("PK__CDTributacao");

                entity.ToTable("_CDTributacao");

                entity.Property(e => e.CdTribut)
                    .HasColumnName("cd_tribut")
                    .HasMaxLength(255);

                entity.Property(e => e.DescTribut)
                    .HasColumnName("desc_tribut")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Cliente)
                    .HasName("Clientes$PrimaryKey");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Apt)
                    .HasColumnName("APT")
                    .HasMaxLength(255);

                entity.Property(e => e.Bairro).HasColumnName("BAIRRO");

                entity.Property(e => e.Bloco)
                    .HasColumnName("BLOCO")
                    .HasMaxLength(255);

                entity.Property(e => e.Celular1)
                    .HasColumnName("CELULAR 1")
                    .HasMaxLength(11);

                entity.Property(e => e.Celular2)
                    .HasColumnName("CELULAR 2")
                    .HasMaxLength(11);

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(16);

                entity.Property(e => e.Cnpjcpf)
                    .HasColumnName("CNPJCPF")
                    .HasMaxLength(255);

                entity.Property(e => e.Comp)
                    .HasColumnName("COMP")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.Fisicajuridica).HasColumnName("FISICAJURIDICA");

                entity.Property(e => e.Gnf).HasColumnName("GNF");

                entity.Property(e => e.Inscricaoestadual)
                    .HasColumnName("INSCRICAOESTADUAL")
                    .HasMaxLength(255);

                entity.Property(e => e.Inscricaomunicipal)
                    .HasColumnName("INSCRICAOMUNICIPAL")
                    .HasMaxLength(255);

                entity.Property(e => e.Localidade).HasColumnName("LOCALIDADE");

                entity.Property(e => e.Logradouro).HasColumnName("LOGRADOURO");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(255);

                entity.Property(e => e.Observações)
                    .HasColumnName("OBSERVAÇÕES")
                    .HasMaxLength(255);

                entity.Property(e => e.Razaosocial)
                    .HasColumnName("RAZAOSOCIAL")
                    .HasMaxLength(255);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefone1)
                    .HasColumnName("TELEFONE 1")
                    .HasMaxLength(12);

                entity.Property(e => e.Telefone2)
                    .HasColumnName("TELEFONE 2")
                    .HasMaxLength(12);

                entity.Property(e => e.Tipo).HasColumnName("TIPO");
            });

            modelBuilder.Entity<Cnaes>(entity =>
            {
                entity.HasKey(e => e.Cnae)
                    .HasName("PK__CNAEs");

                entity.ToTable("_CNAEs");

                entity.Property(e => e.Cnae)
                    .HasColumnName("CNAE")
                    .HasMaxLength(255);

                entity.Property(e => e.CnaeDesc)
                    .HasColumnName("CNAE_Desc")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CodServiços>(entity =>
            {
                entity.HasKey(e => e.CodServiço)
                    .HasName("Cod_Serviços$PrimaryKey");

                entity.ToTable("Cod_Serviços");

                entity.Property(e => e.CodServiço)
                    .HasColumnName("COD SERVIÇO")
                    .HasMaxLength(255);

                entity.Property(e => e.Descrição)
                    .HasColumnName("DESCRIÇÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<CodVendas>(entity =>
            {
                entity.HasKey(e => e.CodVenda)
                    .HasName("Cod_Vendas$PrimaryKey");

                entity.ToTable("Cod_Vendas");

                entity.Property(e => e.CodVenda)
                    .HasColumnName("COD VENDA")
                    .HasMaxLength(255);

                entity.Property(e => e.Descrição)
                    .HasColumnName("DESCRIÇÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Condominios>(entity =>
            {
                entity.HasKey(e => e.IdCondominio)
                    .HasName("PK_Condominios");

                entity.Property(e => e.IdCondominio).HasColumnName("id_condominio");

                entity.Property(e => e.Anotaciones).HasMaxLength(2000);

                entity.Property(e => e.AquecedorExistente).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.Bairro).HasMaxLength(50);

                entity.Property(e => e.CargoContacto).HasMaxLength(50);

                entity.Property(e => e.Ciudad).HasMaxLength(50);

                entity.Property(e => e.D2previsto).HasColumnName("D2Previsto");

                entity.Property(e => e.DataEntrega).HasMaxLength(50);

                entity.Property(e => e.Direccion).HasMaxLength(250);

                entity.Property(e => e.EmailContacto)
                    .HasColumnName("emailContacto")
                    .HasMaxLength(50);

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.Estatus).HasMaxLength(50);

                entity.Property(e => e.FechaAlta).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFoto1).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFoto2).HasColumnType("smalldatetime");

                entity.Property(e => e.GostariaReceberProposta).HasMaxLength(50);

                entity.Property(e => e.Imagenbits)
                    .HasColumnName("imagenbits")
                    .HasColumnType("image");

                entity.Property(e => e.Imagenbits2)
                    .HasColumnName("imagenbits2")
                    .HasColumnType("image");

                entity.Property(e => e.Imagenbitsreducida)
                    .HasColumnName("imagenbitsreducida")
                    .HasColumnType("image");

                entity.Property(e => e.InstalacaoGasInterna).HasMaxLength(50);

                entity.Property(e => e.InvComercial).HasDefaultValueSql("0");

                entity.Property(e => e.InvIrc)
                    .HasColumnName("InvIRC")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InvRedExterna).HasDefaultValueSql("0");

                entity.Property(e => e.InvRedInterna).HasDefaultValueSql("0");

                entity.Property(e => e.MetrosAredMasProxima).HasColumnName("MetrosARedMasProxima");

                entity.Property(e => e.MetrosRedExterna).HasDefaultValueSql("0");

                entity.Property(e => e.Municipio).HasMaxLength(100);

                entity.Property(e => e.Niveldevida)
                    .HasColumnName("niveldevida")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100);

                entity.Property(e => e.Nomimagen)
                    .HasColumnName("nomimagen")
                    .HasMaxLength(250);

                entity.Property(e => e.Nomimagen2)
                    .HasColumnName("nomimagen2")
                    .HasMaxLength(250);

                entity.Property(e => e.Numerodeviviendas).HasColumnName("numerodeviviendas");

                entity.Property(e => e.Numviviendasreal)
                    .HasColumnName("numviviendasreal")
                    .HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.ObservacionesInteres).HasMaxLength(50);

                entity.Property(e => e.ObservacionesInteresContacto).HasMaxLength(250);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.PercepcaoProducto).HasMaxLength(50);

                entity.Property(e => e.PersonaDeContacto).HasMaxLength(50);

                entity.Property(e => e.Plexistente)
                    .HasColumnName("PLExistente")
                    .HasMaxLength(50);

                entity.Property(e => e.Porcentajeocupacion).HasColumnName("porcentajeocupacion");

                entity.Property(e => e.PresionRed).HasMaxLength(50);

                entity.Property(e => e.RexternaMedio).HasColumnName("RExternaMedio");

                entity.Property(e => e.RinternaMedio).HasColumnName("RInternaMedio");

                entity.Property(e => e.TelefonoContacto).HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TipoCombustibleActual).HasMaxLength(50);

                entity.Property(e => e.TipoConstrucao).HasMaxLength(50);

                entity.Property(e => e.TipoNegocio).HasMaxLength(50);

                entity.Property(e => e.ValorIrcmedio).HasColumnName("ValorIRCMedio");

                entity.Property(e => e.ZipCode).HasMaxLength(15);
            });

            modelBuilder.Entity<Contas>(entity =>
            {
                entity.HasIndex(e => e.Cliente)
                    .HasName("Contas$ClientesContas");

                entity.HasIndex(e => e.Conta)
                    .HasName("Contas$Tipo de ContaContas");

                entity.HasIndex(e => e.Favorecido)
                    .HasName("Contas${9608DE6C-E6FB-431C-8B74-EEDEB4A3A227}");

                entity.HasIndex(e => e.IdCaixa)
                    .HasName("Contas$IdCaixax");

                entity.HasIndex(e => e.IdCaixa2)
                    .HasName("Contas$IdCaixa2");

                entity.Property(e => e.Agencia).HasColumnName("AGENCIA");

                entity.Property(e => e.Aliquota).HasDefaultValueSql("0");

                entity.Property(e => e.BaseCalculo)
                    .HasComputedColumnSql("[IMPORTE]-([ValorDeducoes]+[DESCONTOS])")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CodigoCnae).HasMaxLength(255);

                entity.Property(e => e.CodigoTributacaoMunicipio).HasMaxLength(20);

                entity.Property(e => e.ComprovantePgto).HasColumnName("COMPROVANTE PGTO");

                entity.Property(e => e.Conta).HasColumnName("CONTA");

                entity.Property(e => e.Contrato).HasColumnName("CONTRATO");

                entity.Property(e => e.DataDoc)
                    .HasColumnName("DATA DOC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataMovimento).HasColumnType("smalldatetime");

                entity.Property(e => e.DataVencimento).HasColumnType("smalldatetime");

                entity.Property(e => e.Datamovvto)
                    .HasColumnName("DATAMOVVTO")
                    .HasColumnType("smalldatetime")
                    .HasComputedColumnSql("case when [DATAMOVIMENTO] IS NULL then [DATAVENCIMENTO] else [DATAMOVIMENTO] end")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.DescontoCondicionado).HasDefaultValueSql("0");

                entity.Property(e => e.Descontos)
                    .HasColumnName("DESCONTOS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Documento).HasColumnName("DOCUMENTO");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Entrada)
                    .HasColumnName("ENTRADA")
                    .HasComputedColumnSql("case when [CONTA]=(126) then [IMPORTE] else [IMPORTE]-((((((((([ValorPis]+[ValorCofins])+[ValorInss])+[ValorIr])+[ValorCsll])+[DescontoCondicionado])+[DESCONTOS])+[OutrasRetencoes])+case when [CONTA]=(126) then (-1)*[IMPORTE] else ([RETENÇÃO]*[IMPORTE])/CONVERT([float],(100)) end)+case when [IssRetido]=(1) then (([IMPORTE]-([ValorDeducoes]+[DESCONTOS]))*[Aliquota])/CONVERT([float],(100)) else (0) end) end")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Favorecido)
                    .HasColumnName("FAVORECIDO")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Filial).HasColumnName("FILIAL");

                entity.Property(e => e.GnscertEquipamentos).HasColumnName("GNSCertEquipamentos");

                entity.Property(e => e.Histórico)
                    .HasColumnName("HISTÓRICO")
                    .HasMaxLength(255);

                entity.Property(e => e.IcNf)
                    .HasColumnName("ic_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCaixa2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("20");

                entity.Property(e => e.IdCaixa3)
                    .HasComputedColumnSql("case when [DataMovimento] IS NULL then (0) else round(log(CONVERT([float],[DataMovimento])),(0)) end")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IdCaixa4)
                    .HasComputedColumnSql("case when case when [DataMovimento] IS NULL then (0) else round(log(CONVERT([float],[DataMovimento])),(0)) end=(0) AND [CONTA]<(299) then (1) else (2) end")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IdCaixa5)
                    .HasComputedColumnSql("case when case when [DataMovimento] IS NULL then (0) else round(log(CONVERT([float],[DataMovimento])),(0)) end=(0) AND [CONTA]>(299) then (1) else (2) end")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Importe)
                    .HasColumnName("IMPORTE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Impostos)
                    .HasColumnName("IMPOSTOS")
                    .HasComputedColumnSql("(((([ValorPis]+[ValorCofins])+[ValorInss])+[ValorIr])+[ValorCsll])+case when [IssRetido]=(1) then (([IMPORTE]-([ValorDeducoes]+[DESCONTOS]))*[Aliquota])/CONVERT([float],(100)) else CONVERT([float],(0)) end")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.LoteNf).HasColumnName("lote_nf");

                entity.Property(e => e.NatopNf)
                    .HasColumnName("natop_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.Ncert).HasColumnName("NCERT");

                entity.Property(e => e.Npedido).HasColumnName("NPEDIDO");

                entity.Property(e => e.NumDoc)
                    .HasColumnName("NUM DOC")
                    .HasMaxLength(255);

                entity.Property(e => e.Observações)
                    .HasColumnName("OBSERVAÇÕES")
                    .HasMaxLength(255);

                entity.Property(e => e.OpsnNf)
                    .HasColumnName("opsn_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.OutrasRetencoes).HasDefaultValueSql("0");

                entity.Property(e => e.RegimeEspecialTributacao).HasMaxLength(255);

                entity.Property(e => e.Retenção)
                    .HasColumnName("RETENÇÃO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Retenções)
                    .HasColumnName("RETENÇÕES")
                    .HasComputedColumnSql("case when [CONTA]=(126) then (-1)*[IMPORTE] else ([RETENÇÃO]*[IMPORTE])/CONVERT([float],(100)) end")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Saída)
                    .HasColumnName("SAÍDA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeriNf)
                    .HasColumnName("seri_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.Setor).HasColumnName("SETOR");

                entity.Property(e => e.StatusRps)
                    .HasColumnName("status_rps")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO DOC")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoNf)
                    .HasColumnName("tipo_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(255);

                entity.Property(e => e.ValorCofins).HasDefaultValueSql("0");

                entity.Property(e => e.ValorCsll).HasDefaultValueSql("0");

                entity.Property(e => e.ValorDeducoes).HasDefaultValueSql("0");

                entity.Property(e => e.ValorInss).HasDefaultValueSql("0");

                entity.Property(e => e.ValorIr).HasDefaultValueSql("0");

                entity.Property(e => e.ValorIss)
                    .HasComputedColumnSql("[IMPORTE]-([ValorDeducoes]+[DESCONTOS]))*[Aliquota])/CONVERT([float],(100")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorIssRetido)
                    .HasComputedColumnSql("case when [IssRetido]=(1) then (([IMPORTE]-([ValorDeducoes]+[DESCONTOS]))*[Aliquota])/CONVERT([float],(100)) else (0) end")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorLiquido)
                    .HasColumnName("ValorLIquido")
                    .HasComputedColumnSql("case when [CONTA]=(126) then [IMPORTE] else [IMPORTE]-(((((((([ValorPis]+[ValorCofins])+[ValorInss])+[ValorIr])+[ValorCsll])+[DescontoCondicionado])+[DESCONTOS])+[OutrasRetencoes])+case when [IssRetido]=(1) then (([IMPORTE]-([ValorDeducoes]+[DESCONTOS]))*[Aliquota])/CONVERT([float],(100)) else (0) end) end")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorPis).HasDefaultValueSql("0");

                entity.HasOne(d => d.AgenciaNavigation)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.Agencia)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Contas_20_Agencias");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Contas_Clientes");

                entity.HasOne(d => d.ContaNavigation)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.Conta)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Contas_Tipo de Conta");

                entity.HasOne(d => d.ContratoNavigation)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.Contrato)
                    .HasConstraintName("FK_Contas_20_Contratos");

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.Empresa)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Contas_00_Empresa");

                entity.HasOne(d => d.FavorecidoNavigation)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.Favorecido)
                    .HasConstraintName("FK_Contas_Favorecidos");

                entity.HasOne(d => d.FilialNavigation)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.Filial)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Contas_00_Filial");

                entity.HasOne(d => d.IdCaixaNavigation)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.IdCaixa)
                    .HasConstraintName("FK_Contas_20_EntidadesBancarias");

                entity.HasOne(d => d.SetorNavigation)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.Setor)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Contas_00_Setores");

                entity.HasOne(d => d.TipoDocNavigation)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.TipoDoc)
                    .HasConstraintName("FK_Contas_Tipo De Documento");
            });

            modelBuilder.Entity<Favorecidos>(entity =>
            {
                entity.HasKey(e => e.Favorecido)
                    .HasName("PK_Favorecidos");

                entity.HasIndex(e => e.Bairro)
                    .HasName("Favorecidos${0B913630-FE89-4D20-9863-A0107F7793F2}");

                entity.HasIndex(e => e.Estado)
                    .HasName("Favorecidos${B3CD6604-D201-4E38-A484-29E09B5B1F53}");

                entity.HasIndex(e => e.Funcionarioid)
                    .HasName("Favorecidos$FUNCIONARIOID");

                entity.HasIndex(e => e.Localidade)
                    .HasName("Favorecidos${6CC10CE7-57B9-4949-B6E0-88E5D224CD63}");

                entity.HasIndex(e => e.Logradouro)
                    .HasName("Favorecidos${CD293B7B-C978-4306-95C0-C3773224C8B5}");

                entity.HasIndex(e => e.Numeroconta)
                    .HasName("Favorecidos$CONTA1");

                entity.HasIndex(e => e.Parceiroid)
                    .HasName("Favorecidos$PARCEIROID");

                entity.HasIndex(e => e.Tipo)
                    .HasName("Favorecidos${4563701D-9608-4192-9356-877FD38383A0}");

                entity.Property(e => e.Favorecido).HasColumnName("FAVORECIDO");

                entity.Property(e => e.Agencia)
                    .HasColumnName("AGENCIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Apt)
                    .HasColumnName("APT")
                    .HasMaxLength(255);

                entity.Property(e => e.Bairro)
                    .HasColumnName("BAIRRO")
                    .HasDefaultValueSql("12260");

                entity.Property(e => e.Banco).HasColumnName("BANCO");

                entity.Property(e => e.Bloco)
                    .HasColumnName("BLOCO")
                    .HasMaxLength(255);

                entity.Property(e => e.Celular1)
                    .HasColumnName("CELULAR 1")
                    .HasMaxLength(11);

                entity.Property(e => e.Celular2)
                    .HasColumnName("CELULAR 2")
                    .HasMaxLength(11);

                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .HasMaxLength(14);

                entity.Property(e => e.Comp)
                    .HasColumnName("COMP")
                    .HasMaxLength(255);

                entity.Property(e => e.ContaBancária)
                    .IsRequired()
                    .HasColumnName("CONTA BANCÁRIA")
                    .HasMaxLength(542)
                    .HasComputedColumnSql("((isnull(CONVERT([nvarchar],[BANCO]),'')+' ')+isnull([AGENCIA],''))+' ')+isnull([NUMEROCONTA],''")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(14);

                entity.Property(e => e.Dva)
                    .HasColumnName("DVA")
                    .HasMaxLength(1);

                entity.Property(e => e.Dvc)
                    .HasColumnName("DVC")
                    .HasMaxLength(1);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasDefaultValueSql("19");

                entity.Property(e => e.Funcionarioid)
                    .HasColumnName("FUNCIONARIOID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Localidade)
                    .HasColumnName("LOCALIDADE")
                    .HasDefaultValueSql("7043");

                entity.Property(e => e.Logradouro)
                    .HasColumnName("LOGRADOURO")
                    .HasDefaultValueSql("363285");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(255);

                entity.Property(e => e.Numeroconta)
                    .HasColumnName("NUMEROCONTA")
                    .HasMaxLength(255);

                entity.Property(e => e.Observações)
                    .HasColumnName("OBSERVAÇÕES")
                    .HasMaxLength(255);

                entity.Property(e => e.Parceiroid)
                    .HasColumnName("PARCEIROID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefone1)
                    .HasColumnName("TELEFONE 1")
                    .HasMaxLength(10);

                entity.Property(e => e.Telefone2)
                    .HasColumnName("TELEFONE 2")
                    .HasMaxLength(10);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("9");

                entity.Property(e => e.Tipoconta).HasColumnName("TIPOCONTA");

                entity.Property(e => e.Tipofavorecido)
                    .HasColumnName("TIPOFAVORECIDO")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Funcionários>(entity =>
            {

                entity.HasIndex(e => e.Contadorid)
                    .HasName("Funcionários$CONTADORID");

                entity.HasIndex(e => e.Empresa)
                    .HasName("Funcionários$00_EmpresaFuncionários");

                entity.HasIndex(e => e.Escolaridade)
                    .HasName("Funcionários${3CB1EC1F-8033-4054-8B44-F07C531CFB62}");


                entity.HasIndex(e => e.Filial)
                    .HasName("Funcionários$00_FilialFuncionários");


                entity.HasIndex(e => e.Logradouro)
                    .HasName("Funcionários${B31DBA61-D7F1-466A-961B-DDC04391F7B2}");

                entity.HasIndex(e => e.NomeCompleto)
                    .HasName("Funcionários$NOME COMPLETO")
                    .IsUnique();

                entity.HasIndex(e => e.Numeroconta)
                    .HasName("Funcionários$NUMEROCONTA");

                entity.HasIndex(e => e.Riocardmat)
                    .HasName("Funcionários$IDRIOCARD");

                entity.HasIndex(e => e.Setor)
                    .HasName("Funcionários$00_SetoresFuncionários");


                entity.HasIndex(e => e.Tipoconta)
                    .HasName("Funcionários${87234F84-E662-4EDE-9395-D3389C504C49}");

                entity.HasIndex(e => e.Tipovr)
                    .HasName("Funcionários$30_VTVRTiposFuncionários1");

                entity.HasIndex(e => e.Tipovt)
                    .HasName("Funcionários$30_VTVRTiposFuncionários");

                entity.HasIndex(e => e.TituloFunção)
                    .HasName("Funcionários${7ED85238-3B98-4320-B987-40F311124165}");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Agencia)
                    .HasColumnName("AGENCIA")
                    .HasMaxLength(5);

                entity.Property(e => e.Apt)
                    .HasColumnName("APT")
                    .HasMaxLength(255);

                

                entity.Property(e => e.Banco).HasColumnName("BANCO");

                entity.Property(e => e.Bloco)
                    .HasColumnName("BLOCO")
                    .HasMaxLength(255);

                entity.Property(e => e.Blusa)
                    .HasColumnName("BLUSA")
                    .HasMaxLength(255);

                entity.Property(e => e.Bota).HasColumnName("BOTA");

                entity.Property(e => e.CadastroPis)
                    .HasColumnName("CADASTRO PIS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Calça).HasColumnName("CALÇA");

                entity.Property(e => e.CarteiraProfissional)
                    .HasColumnName("CARTEIRA PROFISSIONAL")
                    .HasMaxLength(255);

                entity.Property(e => e.CelPessoal)
                    .HasColumnName("CEL PESSOAL")
                    .HasMaxLength(15);

                entity.Property(e => e.CelPessoal2)
                    .HasColumnName("CEL PESSOAL 2")
                    .HasMaxLength(15);

                entity.Property(e => e.Comp)
                    .HasColumnName("COMP")
                    .HasMaxLength(255);

                entity.Property(e => e.ContaBancária)
                    .IsRequired()
                    .HasColumnName("CONTA BANCÁRIA")
                    .HasMaxLength(49)
                    .HasComputedColumnSql("((isnull(CONVERT([nvarchar],[BANCO]),'')+' ')+isnull([AGENCIA],''))+' ')+isnull([NUMEROCONTA],''")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Contadorid)
                    .HasColumnName("CONTADORID")
                    .HasMaxLength(6);

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(14);

                entity.Property(e => e.DataDeAdmissão)
                    .HasColumnName("DATA DE ADMISSÃO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataDeDemissão)
                    .HasColumnName("DATA DE DEMISSÃO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataDeNascimento)
                    .HasColumnName("DATA DE NASCIMENTO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datarg)
                    .HasColumnName("DATARG")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dva)
                    .HasColumnName("DVA")
                    .HasMaxLength(1);

                entity.Property(e => e.Dvc)
                    .HasColumnName("DVC")
                    .HasMaxLength(1);

                entity.Property(e => e.EMailCorporativo)
                    .HasColumnName("E-MAIL CORPORATIVO")
                    .HasMaxLength(255);

                entity.Property(e => e.EMailPessoal)
                    .HasColumnName("E-MAIL PESSOAL")
                    .HasMaxLength(255);

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Escolaridade).HasColumnName("ESCOLARIDADE");


                entity.Property(e => e.Estadocivil).HasColumnName("ESTADOCIVIL");

                entity.Property(e => e.ExpediçãoTítulo)
                    .HasColumnName("EXPEDIÇÃO TÍTULO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Experienciagas)
                    .HasColumnName("EXPERIENCIAGAS")
                    .HasColumnType("decimal");

                entity.Property(e => e.Filial).HasColumnName("FILIAL");

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.LocalFoto).HasMaxLength(255);


                entity.Property(e => e.Login)
                    .HasColumnName("LOGIN")
                    .HasMaxLength(255);

                entity.Property(e => e.Logradouro).HasColumnName("LOGRADOURO");

                entity.Property(e => e.Master)
                    .HasColumnName("MASTER")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Motivodeslig)
                    .HasColumnName("MOTIVODESLIG")
                    .HasColumnType("decimal");

                entity.Property(e => e.NomeCompleto)
                    .IsRequired()
                    .HasColumnName("NOME COMPLETO")
                    .HasMaxLength(255);

                entity.Property(e => e.Nomemae)
                    .HasColumnName("NOMEMAE")
                    .HasMaxLength(255);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(255);

                entity.Property(e => e.Numeroconta)
                    .HasColumnName("NUMEROCONTA")
                    .HasMaxLength(12);

                entity.Property(e => e.NºDoTítulo)
                    .HasColumnName("Nº DO TÍTULO")
                    .HasMaxLength(255);

                entity.Property(e => e.Pc).HasColumnName("PC");

                entity.Property(e => e.Pis)
                    .HasColumnName("PIS")
                    .HasMaxLength(255);

                entity.Property(e => e.Produto)
                    .HasColumnName("PRODUTO")
                    .HasColumnType("decimal");

                entity.Property(e => e.Ramal).HasColumnName("RAMAL");

                entity.Property(e => e.Rg)
                    .HasColumnName("RG")
                    .HasMaxLength(255);

                entity.Property(e => e.Riocardcart)
                    .HasColumnName("RIOCARDCART")
                    .HasMaxLength(13);

                entity.Property(e => e.Riocardmat)
                    .HasColumnName("RIOCARDMAT")
                    .HasMaxLength(15);

                entity.Property(e => e.Senha)
                    .HasColumnName("SENHA")
                    .HasMaxLength(32);

                entity.Property(e => e.Setor).HasColumnName("SETOR");

                entity.Property(e => e.Sexo)
                    .HasColumnName("SEXO")
                    .HasMaxLength(255);

                entity.Property(e => e.Sistema)
                    .HasColumnName("SISTEMA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasComputedColumnSql("case when [DATA DE DEMISSÃO] IS NULL then (1) else (2) end")
                    .ValueGeneratedOnAddOrUpdate();



                entity.Property(e => e.Tipoconta)
                    .HasColumnName("TIPOCONTA")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tipovr).HasColumnName("TIPOVR");

                entity.Property(e => e.Tipovt).HasColumnName("TIPOVT");

                entity.Property(e => e.TituloFunção).HasColumnName("TITULO (FUNÇÃO)");

                entity.Property(e => e.TlfFixoPessoal)
                    .HasColumnName("TLF FIXO PESSOAL")
                    .HasMaxLength(14);

                entity.Property(e => e.Ufrg)
                    .HasColumnName("UFRG")
                    .HasMaxLength(255);

                entity.Property(e => e.Vr)
                    .HasColumnName("VR")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Vt)
                    .HasColumnName("VT")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ÓrgaoEmisor)
                    .HasColumnName("ÓRGAO EMISOR")
                    .HasMaxLength(255);

                entity.HasOne(d => d.BancoNavigation)
                    .WithMany(p => p.Funcionários)
                    .HasForeignKey(d => d.Banco)
                    .HasConstraintName("FK_Funcionários_20_EntidadesBancarias");

                entity.HasOne(d => d.EscolaridadeNavigation)
                    .WithMany(p => p.Funcionários)
                    .HasForeignKey(d => d.Escolaridade)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Funcionários_30_Escolaridade");

                entity.HasOne(d => d.EstadocivilNavigation)
                    .WithMany(p => p.Funcionários)
                    .HasForeignKey(d => d.Estadocivil)
                    .HasConstraintName("FK_Funcionários_30_EstadoCivil");

                entity.HasOne(d => d.TipocontaNavigation)
                    .WithMany(p => p.Funcionários)
                    .HasForeignKey(d => d.Tipoconta)
                    .HasConstraintName("FK_Funcionários_30_TiposContaBancaria");

                entity.HasOne(d => d.TipovrNavigation)
                    .WithMany(p => p.Funcionários)
                    .HasForeignKey(d => d.Tipovr)
                    .HasConstraintName("FK_Funcionários_30_VTVRTipos");

                entity.HasOne(d => d.TituloFunçãoNavigation)
                    .WithMany(p => p.Funcionários)
                    .HasForeignKey(d => d.TituloFunção)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Funcionários_30_Cargos");
            });

            modelBuilder.Entity<ItensServ>(entity =>
            {
                entity.ToTable("_Itens_Serv");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CdItem)
                    .HasColumnName("cd_item")
                    .HasMaxLength(255);

                entity.Property(e => e.Cdtributacao)
                    .HasColumnName("cdtributacao")
                    .HasMaxLength(255);

                entity.Property(e => e.DescItem)
                    .HasColumnName("desc_item")
                    .HasMaxLength(255);

                entity.Property(e => e.DescItem2)
                    .HasColumnName("desc_item2")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Statussistema).HasColumnName("STATUSSISTEMA");

                entity.Property(e => e.Ultimobanco)
                    .HasColumnName("ULTIMOBANCO")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<NfeCfop>(entity =>
            {
                entity.HasKey(e => e.Cfop)
                    .HasName("PK_NFe_CFOP");

                entity.ToTable("NFe_CFOP");

                entity.Property(e => e.Cfop).HasColumnName("CFOP");

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NfeDiretorios>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("NFe_Diretorios$PrimaryKey");

                entity.ToTable("NFe_Diretorios");

                entity.Property(e => e.Diretorio).HasMaxLength(255);

                entity.Property(e => e.TipoArquivo).HasMaxLength(50);
            });

            modelBuilder.Entity<NfeIbge>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_NFe_IBGE");

                entity.ToTable("NFe_IBGE");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(255);

                entity.Property(e => e.Cidade)
                    .HasColumnName("CIDADE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NfeIbgeUf>(entity =>
            {
                entity.HasKey(e => e.CdUf)
                    .HasName("PK_NFe_IBGE_UF");

                entity.ToTable("NFe_IBGE_UF");

                entity.Property(e => e.CdUf)
                    .HasColumnName("CD_UF")
                    .HasMaxLength(255);

                entity.Property(e => e.Certificadora).HasMaxLength(255);

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NfeInfAdicionais>(entity =>
            {
                entity.HasKey(e => e.CodigoIntInfAdicionais)
                    .HasName("NFe_InfAdicionais$PrimaryKey");

                entity.ToTable("NFe_InfAdicionais");

                entity.HasIndex(e => e.BnfeNNf)
                    .HasName("NFe_InfAdicionais$BNFe_nNF")
                    .IsUnique();

                entity.HasIndex(e => e.CodigoIntInfNotaFiscal)
                    .HasName("NFe_InfAdicionais$Tb_Nfe_InfAdicionaisINFe_cod_NFe");

                entity.Property(e => e.CodigoIntInfAdicionais).HasColumnName("CodigoInt_InfAdicionais");

                entity.Property(e => e.AdCfop)
                    .HasColumnName("Ad_CFOP")
                    .HasMaxLength(255);

                entity.Property(e => e.AdIcms)
                    .HasColumnName("Ad_ICMS")
                    .HasMaxLength(255);

                entity.Property(e => e.AdIndProc)
                    .HasColumnName("Ad_indProc")
                    .HasMaxLength(1);

                entity.Property(e => e.AdInfAdFisco).HasColumnName("Ad_infAdFisco");

                entity.Property(e => e.AdInfCpl).HasColumnName("Ad_infCpl");

                entity.Property(e => e.AdIpi)
                    .HasColumnName("Ad_IPI")
                    .HasMaxLength(255);

                entity.Property(e => e.AdNProc)
                    .HasColumnName("Ad_nProc")
                    .HasMaxLength(60);

                entity.Property(e => e.AdXCampoContr)
                    .HasColumnName("Ad_xCampo_Contr")
                    .HasMaxLength(20);

                entity.Property(e => e.AdXCampoFisco)
                    .HasColumnName("Ad_xCampo_Fisco")
                    .HasMaxLength(20);

                entity.Property(e => e.AdXTextoContr)
                    .HasColumnName("Ad_xTexto_Contr")
                    .HasMaxLength(60);

                entity.Property(e => e.AdXTextoFisco)
                    .HasColumnName("Ad_xTexto_Fisco")
                    .HasMaxLength(60);

                entity.Property(e => e.BnfeNNf)
                    .IsRequired()
                    .HasColumnName("BNFe_nNF")
                    .HasMaxLength(9);

                entity.Property(e => e.CodigoIntInfNotaFiscal).HasColumnName("CodigoInt_InfNotaFiscal");
            });

            modelBuilder.Entity<NfeInfCancelamento>(entity =>
            {
                entity.HasKey(e => e.CodigoIntInfCancelamento)
                    .HasName("NFe_InfCancelamento$CodigoCancela");

                entity.ToTable("NFe_InfCancelamento");

                entity.HasIndex(e => e.CodigoIntInfNotaFiscal)
                    .HasName("NFe_InfCancelamento$INFe_cod_NFe")
                    .IsUnique();

                entity.Property(e => e.CodigoIntInfCancelamento).HasColumnName("CodigoInt_InfCancelamento");

                entity.Property(e => e.AnfeDataHora)
                    .HasColumnName("ANFe_DataHora")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AnfeJustificativa)
                    .HasColumnName("ANFe_Justificativa")
                    .HasMaxLength(250);

                entity.Property(e => e.AnfeNroProtocoloCancelamento)
                    .HasColumnName("ANFe_NroProtocoloCancelamento")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoIntInfNotaFiscal).HasColumnName("CodigoInt_InfNotaFiscal");
            });

            modelBuilder.Entity<NfeInfNotaFiscal>(entity =>
            {
                entity.HasKey(e => new { e.CodigoIntInfNotaFiscal, e.BnfeNNf })
                    .HasName("NFe_InfNotaFiscal$PrimaryKey");

                entity.ToTable("NFe_InfNotaFiscal");

                entity.HasIndex(e => e.CodigoIntInfNotaFiscal)
                    .HasName("NFe_InfNotaFiscal$Tb_nfe_dgedtINFe_cod_NFe");

                entity.HasIndex(e => e.IdmodEb)
                    .HasName("NFe_InfNotaFiscal$IDMod_EB");

                entity.HasIndex(e => new { e.AnfeNprotocolo, e.AnfeChaveAcesso })
                    .HasName("NFe_InfNotaFiscal$ANFe_NAutorizacao");

                entity.Property(e => e.CodigoIntInfNotaFiscal)
                    .HasColumnName("CodigoInt_InfNotaFiscal")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BnfeNNf)
                    .HasColumnName("BNFe_nNF")
                    .HasMaxLength(9);

                entity.Property(e => e.AnfeCDv)
                    .HasColumnName("ANFe_cDV")
                    .HasColumnType("decimal");

                entity.Property(e => e.AnfeCNf)
                    .HasColumnName("ANFe_cNF")
                    .HasMaxLength(8);

                entity.Property(e => e.AnfeCancelada)
                    .HasColumnName("ANFe_Cancelada")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnfeChaveAcesso)
                    .HasColumnName("ANFe_ChaveAcesso")
                    .HasMaxLength(47);

                entity.Property(e => e.AnfeCodigoBarras)
                    .HasColumnName("ANFe_CodigoBarras")
                    .HasMaxLength(50);

                entity.Property(e => e.AnfeDataHoraProtocolo)
                    .HasColumnName("ANFe_DataHoraProtocolo")
                    .HasMaxLength(50);

                entity.Property(e => e.AnfeEmProcessamento)
                    .HasColumnName("ANFe_EmProcessamento")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnfeEnviada)
                    .HasColumnName("ANFe_Enviada")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnfeNprotocolo)
                    .HasColumnName("ANFe_NProtocolo")
                    .HasMaxLength(47);

                entity.Property(e => e.AnfeNrecibo)
                    .HasColumnName("ANFe_NRecibo")
                    .HasMaxLength(50);

                entity.Property(e => e.BnfeCMunFg)
                    .HasColumnName("BNFe_cMunFG")
                    .HasMaxLength(7);

                entity.Property(e => e.BnfeCUf)
                    .IsRequired()
                    .HasColumnName("BNFe_cUF")
                    .HasMaxLength(2);

                entity.Property(e => e.BnfeDEmi)
                    .HasColumnName("BNFe_dEmi")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.BnfeDSaiEnt)
                    .HasColumnName("BNFe_dSaiEnt")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.BnfeDescNatOp)
                    .HasColumnName("BNFe_DescNatOp")
                    .HasMaxLength(60);

                entity.Property(e => e.BnfeDhCont)
                    .HasColumnName("BNFe_dhCont")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.BnfeFinNfe)
                    .HasColumnName("BNFe_finNFe")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BnfeHSaiEnt)
                    .HasColumnName("BNFe_hSaiEnt")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("CONVERT([datetime],CONVERT([varchar],getdate(),(14)),(14))");

                entity.Property(e => e.BnfeIndPag)
                    .HasColumnName("BNFe_indPag")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BnfeMod)
                    .HasColumnName("BNFe_mod")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("55");

                entity.Property(e => e.BnfeNatOp)
                    .HasColumnName("BNFe_natOp")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BnfeProcEmi)
                    .HasColumnName("BNFe_procEmi")
                    .HasMaxLength(1);

                entity.Property(e => e.BnfeRefNfe)
                    .HasColumnName("BNFe_refNFe")
                    .HasMaxLength(47);

                entity.Property(e => e.BnfeSerie)
                    .HasColumnName("BNFe_serie")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BnfeTpAmb)
                    .HasColumnName("BNFe_tpAmb")
                    .HasMaxLength(1);

                entity.Property(e => e.BnfeTpEmis)
                    .HasColumnName("BNFe_tpEmis")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BnfeTpImp)
                    .HasColumnName("BNFe_tpImp")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BnfeTpNf)
                    .HasColumnName("BNFe_tpNF")
                    .HasColumnType("decimal");

                entity.Property(e => e.BnfeVerProc)
                    .HasColumnName("BNFe_verProc")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'2.00'");

                entity.Property(e => e.BnfeXJust)
                    .HasColumnName("BNFe_xJust")
                    .HasMaxLength(255);

                entity.Property(e => e.CamposAdicionais)
                    .HasColumnName("******** CAMPOS ADICIONAIS")
                    .HasMaxLength(255);

                entity.Property(e => e.CnfeCMun)
                    .HasColumnName("CNFe_cMun")
                    .HasMaxLength(7);

                entity.Property(e => e.CnfeCPais)
                    .HasColumnName("CNFe_cPais")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("1058");

                entity.Property(e => e.CnfeCep)
                    .HasColumnName("CNFe_CEP")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CnfeCnae)
                    .HasColumnName("CNFe_CNAE")
                    .HasMaxLength(7);

                entity.Property(e => e.CnfeCnpj)
                    .HasColumnName("CNFe_CNPJ")
                    .HasMaxLength(14);

                entity.Property(e => e.CnfeCpf)
                    .HasColumnName("CNFe_CPF")
                    .HasMaxLength(11);

                entity.Property(e => e.CnfeCrt)
                    .HasColumnName("CNFe_CRT")
                    .HasMaxLength(1);

                entity.Property(e => e.CnfeFone)
                    .HasColumnName("CNFe_fone")
                    .HasMaxLength(14);

                entity.Property(e => e.CnfeIe)
                    .HasColumnName("CNFe_IE")
                    .HasMaxLength(14);

                entity.Property(e => e.CnfeIest)
                    .HasColumnName("CNFe_IEST")
                    .HasMaxLength(14);

                entity.Property(e => e.CnfeIm)
                    .HasColumnName("CNFe_IM")
                    .HasMaxLength(15);

                entity.Property(e => e.CnfeNro)
                    .HasColumnName("CNFe_nro")
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'.'");

                entity.Property(e => e.CnfeUf)
                    .HasColumnName("CNFe_UF")
                    .HasMaxLength(2);

                entity.Property(e => e.CnfeXBairro)
                    .HasColumnName("CNFe_xBairro")
                    .HasMaxLength(60);

                entity.Property(e => e.CnfeXCpl)
                    .HasColumnName("CNFe_xCpl")
                    .HasMaxLength(60);

                entity.Property(e => e.CnfeXFant)
                    .HasColumnName("CNFe_xFant")
                    .HasMaxLength(60);

                entity.Property(e => e.CnfeXLgr)
                    .HasColumnName("CNFe_xLgr")
                    .HasMaxLength(60);

                entity.Property(e => e.CnfeXMun)
                    .HasColumnName("CNFe_xMun")
                    .HasMaxLength(60);

                entity.Property(e => e.CnfeXNome)
                    .HasColumnName("CNFe_xNome")
                    .HasMaxLength(60);

                entity.Property(e => e.CnfeXPais)
                    .HasColumnName("CNFe_xPais")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("'Brasil'");

                entity.Property(e => e.DadosCobrança)
                    .HasColumnName("*****_DADOS_COBRANÇA_****")
                    .HasMaxLength(50);

                entity.Property(e => e.DadosEmitenteRemetente)
                    .HasColumnName("****_DADOS_EMITENTE/REMETENTE_****")
                    .HasMaxLength(50);

                entity.Property(e => e.DadosNfe)
                    .HasColumnName("*****_DADOS_NFe_*****")
                    .HasMaxLength(50);

                entity.Property(e => e.DadosTransporte)
                    .HasColumnName("****_DADOS_TRANSPORTE_****")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinatarioCliente)
                    .HasColumnName("*****_DESTINATARIO/CLIENTE_****")
                    .HasMaxLength(50);

                entity.Property(e => e.EnfeCMun)
                    .HasColumnName("ENFe_cMun")
                    .HasMaxLength(7);

                entity.Property(e => e.EnfeCPais)
                    .HasColumnName("ENFe_cPais")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("1058");

                entity.Property(e => e.EnfeCep)
                    .HasColumnName("ENFe_CEP")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EnfeCnpj)
                    .HasColumnName("ENFe_CNPJ")
                    .HasMaxLength(14);

                entity.Property(e => e.EnfeCpf)
                    .HasColumnName("ENFe_CPF")
                    .HasMaxLength(11);

                entity.Property(e => e.EnfeEmail)
                    .HasColumnName("ENFe_email")
                    .HasMaxLength(60);

                entity.Property(e => e.EnfeFone)
                    .HasColumnName("ENFe_fone")
                    .HasMaxLength(14);

                entity.Property(e => e.EnfeIe)
                    .HasColumnName("ENFe_IE")
                    .HasMaxLength(14);

                entity.Property(e => e.EnfeIsuf)
                    .HasColumnName("ENFe_ISUF")
                    .HasMaxLength(9);

                entity.Property(e => e.EnfeNro)
                    .HasColumnName("ENFe_nro")
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'.'");

                entity.Property(e => e.EnfeUf)
                    .HasColumnName("ENFe_UF")
                    .HasMaxLength(2);

                entity.Property(e => e.EnfeXBairro)
                    .HasColumnName("ENFe_xBairro")
                    .HasMaxLength(60);

                entity.Property(e => e.EnfeXCpl)
                    .HasColumnName("ENFe_xCpl")
                    .HasMaxLength(60);

                entity.Property(e => e.EnfeXFant)
                    .HasColumnName("ENFe_xFant")
                    .HasMaxLength(60);

                entity.Property(e => e.EnfeXLgr)
                    .HasColumnName("ENFe_xLgr")
                    .HasMaxLength(60);

                entity.Property(e => e.EnfeXMun)
                    .HasColumnName("ENFe_xMun")
                    .HasMaxLength(60);

                entity.Property(e => e.EnfeXNome)
                    .HasColumnName("ENFe_xNome")
                    .HasMaxLength(60);

                entity.Property(e => e.EnfeXPais)
                    .HasColumnName("ENFe_xPais")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'Brasil'");

                entity.Property(e => e.FnfeCMun)
                    .HasColumnName("FNFe_cMun")
                    .HasMaxLength(7);

                entity.Property(e => e.FnfeCnpj)
                    .HasColumnName("FNFe_CNPJ")
                    .HasMaxLength(14);

                entity.Property(e => e.FnfeCpf)
                    .HasColumnName("FNFe_CPF")
                    .HasMaxLength(11);

                entity.Property(e => e.FnfeNro)
                    .HasColumnName("FNFe_nro")
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'.'");

                entity.Property(e => e.FnfeUf)
                    .HasColumnName("FNFe_UF")
                    .HasMaxLength(2);

                entity.Property(e => e.FnfeXBairro)
                    .HasColumnName("FNFe_xBairro")
                    .HasMaxLength(60);

                entity.Property(e => e.FnfeXCpl)
                    .HasColumnName("FNFe_xCpl")
                    .HasMaxLength(60);

                entity.Property(e => e.FnfeXLgr)
                    .HasColumnName("FNFe_xLgr")
                    .HasMaxLength(60);

                entity.Property(e => e.FnfeXMun)
                    .HasColumnName("FNFe_xMun")
                    .HasMaxLength(60);

                entity.Property(e => e.GnfeCMun)
                    .HasColumnName("GNFe_cMun")
                    .HasMaxLength(7);

                entity.Property(e => e.GnfeCnpj)
                    .HasColumnName("GNFe_CNPJ")
                    .HasMaxLength(14);

                entity.Property(e => e.GnfeCpf)
                    .HasColumnName("GNFe_CPF")
                    .HasMaxLength(11);

                entity.Property(e => e.GnfeNro)
                    .HasColumnName("GNFe_nro")
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'.'");

                entity.Property(e => e.GnfeUf)
                    .HasColumnName("GNFe_UF")
                    .HasMaxLength(2);

                entity.Property(e => e.GnfeXBairro)
                    .HasColumnName("GNFe_xBairro")
                    .HasMaxLength(60);

                entity.Property(e => e.GnfeXCpl)
                    .HasColumnName("GNFe_xCpl")
                    .HasMaxLength(60);

                entity.Property(e => e.GnfeXLgr)
                    .HasColumnName("GNFe_xLgr")
                    .HasMaxLength(60);

                entity.Property(e => e.GnfeXMun)
                    .HasColumnName("GNFe_xMun")
                    .HasMaxLength(60);

                entity.Property(e => e.IdentificaçãoNfe)
                    .HasColumnName("****_IDENTIFICAÇÃO_NFe_****")
                    .HasMaxLength(50);

                entity.Property(e => e.IdmodEb).HasColumnName("IDMod_EB");

                entity.Property(e => e.InfoPagto).HasMaxLength(255);

                entity.Property(e => e.InformaçõesAdicionais)
                    .HasColumnName("****_INFORMAÇÕES_ADICIONAIS_****")
                    .HasMaxLength(50);

                entity.Property(e => e.LeiTransparência)
                    .HasColumnName("******* Lei Transparência ********")
                    .HasMaxLength(50);

                entity.Property(e => e.LocalEntrega)
                    .HasColumnName("****_LOCAL_ENTREGA_****")
                    .HasMaxLength(50);

                entity.Property(e => e.LocalRetirada)
                    .HasColumnName("****_LOCAL_RETIRADA_****")
                    .HasMaxLength(50);

                entity.Property(e => e.Processado)
                    .HasColumnName("PROCESSADO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.VTotTrib)
                    .HasColumnName("vTotTrib")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValoresNfe)
                    .HasColumnName("****_VALORES_NFe_*****")
                    .HasMaxLength(50);

                entity.Property(e => e.WnfeIcmstot)
                    .HasColumnName("WNFe_ICMSTot")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeIssqntot)
                    .HasColumnName("WNFe_ISSQNtot")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeReTrib)
                    .HasColumnName("WNFe_reTrib")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeTotal)
                    .HasColumnName("WNFe_total")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVBcicms)
                    .HasColumnName("WNFe_vBCICMS")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeVBcirrf)
                    .HasColumnName("WNFe_vBCIRRF")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVBciss)
                    .HasColumnName("WNFe_vBCISS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVBcretPrev)
                    .HasColumnName("WNFe_vBCRetPrev")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVBcst)
                    .HasColumnName("WNFe_vBCST")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeVCofins)
                    .HasColumnName("WNFe_vCOFINS")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeVCofinsServ)
                    .HasColumnName("WNFe_vCOFINS_serv")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVDesc)
                    .HasColumnName("WNFe_vDesc")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVFrete)
                    .HasColumnName("WNFe_vFrete")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVIcms)
                    .HasColumnName("WNFe_vICMS")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeVIi)
                    .HasColumnName("WNFe_vII")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeVIpi)
                    .HasColumnName("WNFe_vIPI")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeVIpifrete)
                    .HasColumnName("WNFe_vIPIFrete")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVIrrf)
                    .HasColumnName("WNFe_vIRRF")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVIss)
                    .HasColumnName("WNFe_vISS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVNf)
                    .HasColumnName("WNFe_vNF")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeVOutras)
                    .HasColumnName("WNFe_vOutras")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeVPis)
                    .HasColumnName("WNFe_vPIS")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeVPisServ)
                    .HasColumnName("WNFe_vPIS_serv")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVProd)
                    .HasColumnName("WNFe_vProd")
                    .HasColumnType("decimal");

                entity.Property(e => e.WnfeVRetCofins)
                    .HasColumnName("WNFe_vRetCOFINS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVRetCsll)
                    .HasColumnName("WNFe_vRetCSLL")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVRetPis)
                    .HasColumnName("WNFe_vRetPIS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVRetPrev)
                    .HasColumnName("WNFe_vRetPrev")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVSeg)
                    .HasColumnName("WNFe_vSeg")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVServ)
                    .HasColumnName("WNFe_vServ")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WnfeVSt)
                    .HasColumnName("WNFe_vST")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XnfeBalsa)
                    .HasColumnName("XNFe_balsa")
                    .HasMaxLength(20);

                entity.Property(e => e.XnfeCMunFg)
                    .HasColumnName("XNFe_cMunFG")
                    .HasMaxLength(7);

                entity.Property(e => e.XnfeCfop)
                    .HasColumnName("XNFe_CFOP")
                    .HasMaxLength(4);

                entity.Property(e => e.XnfeCnpj)
                    .HasColumnName("XNFe_CNPJ")
                    .HasMaxLength(14);

                entity.Property(e => e.XnfeCpf)
                    .HasColumnName("XNFe_CPF")
                    .HasMaxLength(11);

                entity.Property(e => e.XnfeEspecie)
                    .HasColumnName("XNFe_especie")
                    .HasMaxLength(15);

                entity.Property(e => e.XnfeIe)
                    .HasColumnName("XNFe_IE")
                    .HasMaxLength(14);

                entity.Property(e => e.XnfeMarca)
                    .HasColumnName("XNFe_marca")
                    .HasMaxLength(20);

                entity.Property(e => e.XnfeModFrete)
                    .HasColumnName("XNFe_modFrete")
                    .HasMaxLength(1);

                entity.Property(e => e.XnfeNLacre)
                    .HasColumnName("XNFe_nLacre")
                    .HasMaxLength(60);

                entity.Property(e => e.XnfeNVol)
                    .HasColumnName("XNFe_nVol")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XnfePIcmsret)
                    .HasColumnName("XNFe_pICMSRet")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XnfePesoB)
                    .HasColumnName("XNFe_pesoB")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XnfePesoL)
                    .HasColumnName("XNFe_pesoL")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XnfePlacaReboque)
                    .HasColumnName("XNFe_placa_reboque")
                    .HasMaxLength(8);

                entity.Property(e => e.XnfePlacaVeic)
                    .HasColumnName("XNFe_placa_veic")
                    .HasMaxLength(8);

                entity.Property(e => e.XnfeQVol)
                    .HasColumnName("XNFe_qVol")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XnfeRntcReboque)
                    .HasColumnName("XNFe_RNTC_reboque")
                    .HasMaxLength(20);

                entity.Property(e => e.XnfeRntcVeic)
                    .HasColumnName("XNFe_RNTC_veic")
                    .HasMaxLength(20);

                entity.Property(e => e.XnfeUf)
                    .HasColumnName("XNFe_UF")
                    .HasMaxLength(2);

                entity.Property(e => e.XnfeUfReboque)
                    .HasColumnName("XNFe_UF_reboque")
                    .HasMaxLength(2);

                entity.Property(e => e.XnfeUfVeic)
                    .HasColumnName("XNFe_UF_veic")
                    .HasMaxLength(2);

                entity.Property(e => e.XnfeVBcret)
                    .HasColumnName("XNFe_vBCRet")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XnfeVIcmsret)
                    .HasColumnName("XNFe_vICMSRet")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XnfeVServ)
                    .HasColumnName("XNFe_vServ")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XnfeVagao)
                    .HasColumnName("XNFe_vagao")
                    .HasMaxLength(20);

                entity.Property(e => e.XnfeXEnder)
                    .HasColumnName("XNFe_xEnder")
                    .HasMaxLength(60);

                entity.Property(e => e.XnfeXMun)
                    .HasColumnName("XNFe_xMun")
                    .HasMaxLength(60);

                entity.Property(e => e.XnfeXNome)
                    .HasColumnName("XNFe_xNome")
                    .HasMaxLength(60);

                entity.Property(e => e.YnfeDVenc1)
                    .HasColumnName("YNFe_dVenc1")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.YnfeNDup1)
                    .HasColumnName("YNFe_nDup1")
                    .HasMaxLength(50);

                entity.Property(e => e.YnfeNFat)
                    .HasColumnName("YNFe_nFat")
                    .HasMaxLength(50);

                entity.Property(e => e.YnfeQtdadeDup).HasColumnName("YNFe_QtdadeDup");

                entity.Property(e => e.YnfeTodasDuplicatas).HasColumnName("YNFe_todas_duplicatas");

                entity.Property(e => e.YnfeVDesc).HasColumnName("YNFe_vDesc");

                entity.Property(e => e.YnfeVDup1).HasColumnName("YNFe_vDup1");

                entity.Property(e => e.YnfeVLiq).HasColumnName("YNFe_vLiq");

                entity.Property(e => e.YnfeVOrig).HasColumnName("YNFe_vOrig");

                entity.Property(e => e.ZbnfeContrato)
                    .HasColumnName("ZBNFe_Contrato")
                    .HasMaxLength(16);

                entity.Property(e => e.ZbnfeXNemp)
                    .HasColumnName("ZBNFe_xNemp")
                    .HasMaxLength(17);

                entity.Property(e => e.ZbnfeXPed)
                    .HasColumnName("ZBNFe_xPed")
                    .HasMaxLength(25);

                entity.Property(e => e.ZnfeIdAdicionaisIcms).HasColumnName("ZNFe_idAdicionaisICMS");

                entity.Property(e => e.ZnfeIdAdicionaisIpi).HasColumnName("ZNFe_idAdicionaisIPI");

                entity.Property(e => e.ZnfeInfAdFisco)
                    .HasColumnName("ZNFe_infAdFisco")
                    .HasMaxLength(250);

                entity.Property(e => e.ZnfeInfAdIcms)
                    .HasColumnName("ZNFe_infAdICMS")
                    .HasMaxLength(250);

                entity.Property(e => e.ZnfeInfAdIpi)
                    .HasColumnName("ZNFe_infAdIPI")
                    .HasMaxLength(250);

                entity.Property(e => e.ZnfeInfCpl)
                    .HasColumnName("ZNFe_infCpl")
                    .HasMaxLength(250);

                entity.Property(e => e._)
                    .HasColumnName("***************************")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NfeInfProdutos>(entity =>
            {
                entity.HasKey(e => e.CodigoIntInfProdutos)
                    .HasName("NFe_InfProdutos$PrimaryKey");

                entity.ToTable("NFe_InfProdutos");

                entity.HasIndex(e => e.CodigoIntInfNotaFiscal)
                    .HasName("NFe_InfProdutos$Tb_nfe_IProdutosINFe_cod_NFe");

                entity.HasIndex(e => e.InfeIpivUnid)
                    .HasName("NFe_InfProdutos$INFe_IPIvUnid");

                entity.Property(e => e.CodigoIntInfProdutos).HasColumnName("CodigoInt_InfProdutos");

                entity.Property(e => e.BnfeNNf)
                    .IsRequired()
                    .HasColumnName("BNFe_nNF")
                    .HasMaxLength(9);

                entity.Property(e => e.CodigoIntInfNotaFiscal)
                    .HasColumnName("CodigoInt_InfNotaFiscal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeCEantrib)
                    .HasColumnName("INFe_cEANTrib")
                    .HasMaxLength(14);

                entity.Property(e => e.InfeCEnq)
                    .HasColumnName("INFe_cEnq")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("999");

                entity.Property(e => e.InfeCExportador)
                    .HasColumnName("INFe_cExportador")
                    .HasMaxLength(20);

                entity.Property(e => e.InfeCFabricante)
                    .HasColumnName("INFe_cFabricante")
                    .HasMaxLength(20);

                entity.Property(e => e.InfeCSelo)
                    .HasColumnName("INFe_cSelo")
                    .HasMaxLength(60);

                entity.Property(e => e.InfeCfop)
                    .HasColumnName("INFe_CFOP")
                    .HasMaxLength(4);

                entity.Property(e => e.InfeClEnq)
                    .HasColumnName("INFe_clEnq")
                    .HasMaxLength(50);

                entity.Property(e => e.InfeCnpjprod)
                    .HasColumnName("INFe_CNPJProd")
                    .HasMaxLength(50);

                entity.Property(e => e.InfeCofinscst)
                    .HasColumnName("INFe_COFINSCST")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeCofinsqBcprod)
                    .HasColumnName("INFe_COFINSqBCProd")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeCofinsvAliqProd)
                    .HasColumnName("INFe_COFINSvAliqProd")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeCofinsvBc)
                    .HasColumnName("INFe_COFINSvBC")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeCprod)
                    .HasColumnName("INFe_cprod")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeCst)
                    .HasColumnName("INFe_CST")
                    .HasMaxLength(3);

                entity.Property(e => e.InfeDDesemb)
                    .HasColumnName("INFe_dDesemb")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.InfeDDi)
                    .HasColumnName("INFe_dDI")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.InfeExtipi)
                    .HasColumnName("INFe_EXTIPI")
                    .HasMaxLength(3);

                entity.Property(e => e.InfeGrupoCofins)
                    .HasColumnName("INFe_Grupo COFINS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'S'");

                entity.Property(e => e.InfeGrupoIcms)
                    .HasColumnName("INFe_grupo ICMS")
                    .HasMaxLength(1);

                entity.Property(e => e.InfeGrupoImportacao)
                    .HasColumnName("INFe_Grupo IMPORTACAO")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'P'");

                entity.Property(e => e.InfeGrupoImportacao1)
                    .HasColumnName("INFe_Grupo_Importacao")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'Q'");

                entity.Property(e => e.InfeGrupoIpi)
                    .HasColumnName("INFe_GRUPO_IPI")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'O'");

                entity.Property(e => e.InfeGrupoPis)
                    .HasColumnName("INFe_grupo PIS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'Q'");

                entity.Property(e => e.InfeGrupoProduto)
                    .HasColumnName("INFe_grupo_Produto")
                    .HasMaxLength(1);

                entity.Property(e => e.InfeGrupoReferencias)
                    .HasColumnName("INFe_grupo_Referencias")
                    .HasMaxLength(2);

                entity.Property(e => e.InfeIivBc)
                    .HasColumnName("INFe_IIvBC")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeIndTot)
                    .HasColumnName("INFe_indTot")
                    .HasMaxLength(1);

                entity.Property(e => e.InfeIpicst)
                    .HasColumnName("INFe_IPICST")
                    .HasMaxLength(2);

                entity.Property(e => e.InfeIpiqUnd)
                    .HasColumnName("INFe_IPIqUnd")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeIpivBc)
                    .HasColumnName("INFe_IPIvBC")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeIpivUnid)
                    .HasColumnName("INFe_IPIvUnid")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeIva)
                    .HasColumnName("INFe_IVA")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeModBc)
                    .HasColumnName("INFe_modBC")
                    .HasMaxLength(1);

                entity.Property(e => e.InfeModBcst)
                    .HasColumnName("INFe_modBCST")
                    .HasMaxLength(50);

                entity.Property(e => e.InfeMotDesIcms)
                    .HasColumnName("INFe_motDesICMS")
                    .HasMaxLength(1);

                entity.Property(e => e.InfeNAdicao)
                    .HasColumnName("INFe_nAdicao")
                    .HasMaxLength(3);

                entity.Property(e => e.InfeNDi)
                    .HasColumnName("INFe_nDI")
                    .HasMaxLength(10);

                entity.Property(e => e.InfeNItemPed).HasColumnName("INFe_nItemPed");

                entity.Property(e => e.InfeNSeqAdic)
                    .HasColumnName("INFe_nSeqAdic")
                    .HasMaxLength(3);

                entity.Property(e => e.InfeNcm)
                    .HasColumnName("INFe_NCM")
                    .HasMaxLength(8);

                entity.Property(e => e.InfeOrig)
                    .HasColumnName("INFe_orig")
                    .HasMaxLength(1);

                entity.Property(e => e.InfePBcop)
                    .HasColumnName("INFe_pBCop")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePCofins)
                    .HasColumnName("INFe_pCOFINS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePCredSn)
                    .HasColumnName("INFe_pCredSN")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePIpi)
                    .HasColumnName("INFe_pIPI")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePMvast)
                    .HasColumnName("INFe_pMVAST")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePPis)
                    .HasColumnName("INFe_pPIS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePRedBc)
                    .HasColumnName("INFe_pRedBC")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePRedBcst)
                    .HasColumnName("INFe_pRedBCST")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePesoL)
                    .HasColumnName("INFe_pesoL")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePiscst)
                    .HasColumnName("INFe_PISCST")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePisqBcprod)
                    .HasColumnName("INFe_PISqBCProd")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePisvAliqProd)
                    .HasColumnName("INFe_PISvAliqProd")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePisvBc)
                    .HasColumnName("INFe_PISvBC")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePlCms)
                    .HasColumnName("INFe_plCMS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfePlCmsst)
                    .HasColumnName("INFe_plCMSST")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeProdNitem).HasColumnName("INFe_prod_nitem");

                entity.Property(e => e.InfeQCom)
                    .HasColumnName("INFe_qCom")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeQSelo)
                    .HasColumnName("INFe_qSelo")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeQTrib)
                    .HasColumnName("INFe_qTrib")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeReducao)
                    .HasColumnName("INFe_reducao")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeUCom)
                    .HasColumnName("INFe_uCom")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("'Un'");

                entity.Property(e => e.InfeUTrib)
                    .HasColumnName("INFe_uTrib")
                    .HasMaxLength(6);

                entity.Property(e => e.InfeUfdesemb)
                    .HasColumnName("INFe_UFDesemb")
                    .HasMaxLength(2);

                entity.Property(e => e.InfeUfst)
                    .HasColumnName("INFe_UFST")
                    .HasMaxLength(2);

                entity.Property(e => e.InfeVBc)
                    .HasColumnName("INFe_vBC")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVBcst)
                    .HasColumnName("INFe_vBCST")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVBcstdest)
                    .HasColumnName("INFe_vBCSTDest")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVBcstret)
                    .HasColumnName("INFe_vBCSTRet")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVCofins)
                    .HasColumnName("INFe_vCOFINS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVCredIcmssn)
                    .HasColumnName("INFe_vCredICMSSN")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVDesc)
                    .HasColumnName("INFe_vDesc")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVDescDi)
                    .HasColumnName("INFe_vDescDI")
                    .HasMaxLength(15);

                entity.Property(e => e.InfeVDespAdu)
                    .HasColumnName("INFe_vDespAdu")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVFrete)
                    .HasColumnName("INFe_vFrete")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVIcmsstdest)
                    .HasColumnName("INFe_vICMSSTDest")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVIcmsstret)
                    .HasColumnName("INFe_vICMSSTRet")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVIi)
                    .HasColumnName("INFe_vII")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVIiof)
                    .HasColumnName("INFe_vIIOF")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVIpi)
                    .HasColumnName("INFe_vIPI")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVOutro)
                    .HasColumnName("INFe_vOutro")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVPis)
                    .HasColumnName("INFe_vPIS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVProd)
                    .HasColumnName("INFe_vProd")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVSeg)
                    .HasColumnName("INFe_vSeg")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVUnCom)
                    .HasColumnName("INFe_vUnCom")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVUnTrib)
                    .HasColumnName("INFe_vUnTrib")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVlCms)
                    .HasColumnName("INFe_vlCMS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeVlCmsst)
                    .HasColumnName("INFe_vlCMSST")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfeXEan)
                    .HasColumnName("INFe_xEAN")
                    .HasMaxLength(14);

                entity.Property(e => e.InfeXLocDesemb)
                    .HasColumnName("INFe_xLocDesemb")
                    .HasMaxLength(60);

                entity.Property(e => e.InfeXPed)
                    .HasColumnName("INFe_xPed")
                    .HasMaxLength(15);

                entity.Property(e => e.InfeXProd)
                    .HasColumnName("INFe_xProd")
                    .HasMaxLength(120);

                entity.Property(e => e.LeiTransparência)
                    .HasColumnName("******* Lei Transparência ********")
                    .HasMaxLength(50);

                entity.Property(e => e.NfeInfAdProd)
                    .HasColumnName("NFe_InfAdProd")
                    .HasMaxLength(255);

                entity.Property(e => e.VTotTrib)
                    .HasColumnName("vTotTrib")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NfeParametros>(entity =>
            {
                entity.HasKey(e => e.CodigoInt)
                    .HasName("NFe_Parametros$PrimaryKey");

                entity.ToTable("NFe_Parametros");

                entity.HasIndex(e => e.IdentificacaoAmbiente)
                    .HasName("NFe_Parametros$IdentificacaoAmbiente");

                entity.HasIndex(e => e.NomeFantasia)
                    .HasName("NFe_Parametros$NF_DESTINATARIO");

                entity.Property(e => e.Bairro).HasMaxLength(50);

                entity.Property(e => e.CdUf)
                    .HasColumnName("CD_UF")
                    .HasMaxLength(255);

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(15);

                entity.Property(e => e.Certifiadora).HasMaxLength(255);

                entity.Property(e => e.Certificado).HasDefaultValueSql("'--'");

                entity.Property(e => e.Cnaefiscal)
                    .HasColumnName("CNAEFiscal")
                    .HasMaxLength(7)
                    .HasDefaultValueSql("'--'");

                entity.Property(e => e.CnpjCpf)
                    .HasColumnName("CNPJ_CPF")
                    .HasMaxLength(18)
                    .HasDefaultValueSql("'--'");

                entity.Property(e => e.CodigoIbge)
                    .HasColumnName("CodigoIBGE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DanfeAut).HasMaxLength(1);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EnvConf)
                    .HasColumnName("envConf")
                    .HasMaxLength(1);

                entity.Property(e => e.EnvHtml)
                    .HasColumnName("envHTML")
                    .HasMaxLength(1);

                entity.Property(e => e.Envimsm).HasColumnName("envimsm");

                entity.Property(e => e.IdentificacaoAmbiente)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'2 - Homologação'");

                entity.Property(e => e.Ie)
                    .HasColumnName("IE")
                    .HasMaxLength(40);

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasMaxLength(255);

                entity.Property(e => e.LicencaDll)
                    .HasColumnName("LicencaDLL")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("'--'");

                entity.Property(e => e.Logo).HasDefaultValueSql("0");

                entity.Property(e => e.LogoMarca).HasMaxLength(255);

                entity.Property(e => e.Logradouro).HasMaxLength(60);

                entity.Property(e => e.ModelNf).HasColumnName("ModelNF");

                entity.Property(e => e.Muncipio).HasMaxLength(50);

                entity.Property(e => e.NLogra)
                    .HasColumnName("N_Logra")
                    .HasMaxLength(20);

                entity.Property(e => e.NomeFantasia)
                    .HasColumnName("Nome_Fantasia")
                    .HasMaxLength(70);

                entity.Property(e => e.Proxy)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'--'");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'--'");

                entity.Property(e => e.RgTributario)
                    .HasColumnName("RG_Tributario")
                    .HasDefaultValueSql("1058");

                entity.Property(e => e.SenhaProxy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SiglaWebService).HasMaxLength(50);

                entity.Property(e => e.Smtp)
                    .HasColumnName("smtp")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpMail)
                    .HasColumnName("smtpMail")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpPorta)
                    .HasColumnName("smtpPorta")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpSenha)
                    .HasColumnName("smtpSenha")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpSsl)
                    .HasColumnName("smtpSSL")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpUsuario)
                    .HasColumnName("smtpUsuario")
                    .HasMaxLength(255);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .HasColumnName("SSMA_TimeStamp")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Telefone).HasMaxLength(30);

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.TipoCert).HasMaxLength(255);

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasMaxLength(2);

                entity.Property(e => e.UsuarioProxy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VersaoSchema)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("'--'");

                entity.Property(e => e.WebService)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("'--'");
            });

            modelBuilder.Entity<NfseNotas>(entity =>
            {
                entity.HasKey(e => e.Idnf)
                    .HasName("NFSe_Notas$PrimaryKey");

                entity.ToTable("NFSe_Notas");

                entity.Property(e => e.Idnf).HasColumnName("idnf");

                entity.Property(e => e.Aliquota).HasDefaultValueSql("0");

                entity.Property(e => e.Art)
                    .HasColumnName("ART")
                    .HasMaxLength(255);

                entity.Property(e => e.Atualizado)
                    .HasColumnName("atualizado")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BairroTom)
                    .HasColumnName("bairro_tom")
                    .HasMaxLength(255);

                entity.Property(e => e.Baixado)
                    .HasColumnName("baixado")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BaseCalculo).HasDefaultValueSql("0");

                entity.Property(e => e.CdReDll)
                    .HasColumnName("cd_re_dll")
                    .HasMaxLength(255);

                entity.Property(e => e.CdmunicipioTom)
                    .HasColumnName("cdmunicipio_tom")
                    .HasMaxLength(10);

                entity.Property(e => e.CepTom)
                    .HasColumnName("cep_tom")
                    .HasMaxLength(11);

                entity.Property(e => e.CnpjPrest)
                    .HasColumnName("Cnpj_prest")
                    .HasMaxLength(255);

                entity.Property(e => e.CnpjTom)
                    .HasColumnName("cnpj_tom")
                    .HasMaxLength(255);

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.CodigoCnae).HasMaxLength(255);

                entity.Property(e => e.CodigoObra).HasMaxLength(255);

                entity.Property(e => e.CodigoTributacaoMunicipio).HasMaxLength(20);

                entity.Property(e => e.CompTom)
                    .HasColumnName("comp_tom")
                    .HasMaxLength(255);

                entity.Property(e => e.Datacontrato)
                    .HasColumnName("datacontrato")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DescontoCondicionado).HasDefaultValueSql("0");

                entity.Property(e => e.DescontoIncondicionado).HasDefaultValueSql("0");

                entity.Property(e => e.DtNf)
                    .HasColumnName("dt_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailTom)
                    .HasColumnName("email_tom")
                    .HasMaxLength(80);

                entity.Property(e => e.EndTom)
                    .HasColumnName("end_tom")
                    .HasMaxLength(255);

                entity.Property(e => e.HistEvent).HasColumnName("hist_event");

                entity.Property(e => e.IcNf)
                    .HasColumnName("ic_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.IeTom)
                    .HasColumnName("ie_tom")
                    .HasMaxLength(255);

                entity.Property(e => e.ImPrest)
                    .HasColumnName("IM_prest")
                    .HasMaxLength(255);

                entity.Property(e => e.ImTom)
                    .HasColumnName("im_tom")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfoCliente)
                    .HasColumnName("**** Info Cliente *****")
                    .HasMaxLength(255);

                entity.Property(e => e.IssRetido).HasDefaultValueSql("0");

                entity.Property(e => e.ItemListaServico).HasMaxLength(255);

                entity.Property(e => e.LoteNf).HasColumnName("lote_nf");

                entity.Property(e => e.MunicipTom)
                    .HasColumnName("municip_tom")
                    .HasMaxLength(255);

                entity.Property(e => e.NConta).HasColumnName("nConta");

                entity.Property(e => e.NContrato)
                    .HasColumnName("nContrato")
                    .HasMaxLength(255);

                entity.Property(e => e.NErr)
                    .HasColumnName("nErr")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NNf).HasColumnName("n_nf");

                entity.Property(e => e.NNfse)
                    .HasColumnName("nNFSe")
                    .HasMaxLength(255);

                entity.Property(e => e.NatopNf)
                    .HasColumnName("natop_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.NunTom)
                    .HasColumnName("nun_tom")
                    .HasMaxLength(255);

                entity.Property(e => e.OpsnNf)
                    .HasColumnName("opsn_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.OutrasRetencoes).HasDefaultValueSql("0");

                entity.Property(e => e.ProtocoloDataRec)
                    .HasColumnName("protocolo_data_rec")
                    .HasMaxLength(50);

                entity.Property(e => e.ProtocoloRec)
                    .HasColumnName("protocolo_rec")
                    .HasMaxLength(50);

                entity.Property(e => e.RazaoTom)
                    .HasColumnName("razao_tom")
                    .HasMaxLength(255);

                entity.Property(e => e.RegimeEspecialTributacao).HasMaxLength(255);

                entity.Property(e => e.SCdverificacao)
                    .HasColumnName("sCDVerificacao")
                    .HasMaxLength(255);

                entity.Property(e => e.SDataHoraRetorno)
                    .HasColumnName("sDataHoraRetorno")
                    .HasMaxLength(50);

                entity.Property(e => e.SNprotocolo)
                    .HasColumnName("sNProtocolo")
                    .HasMaxLength(255);

                entity.Property(e => e.SeriNf)
                    .HasColumnName("seri_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusProc)
                    .HasColumnName("Status_Proc")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusRps)
                    .HasColumnName("status_rps")
                    .HasMaxLength(255);

                entity.Property(e => e.TelTom)
                    .HasColumnName("tel_tom")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoNf)
                    .HasColumnName("tipo_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipocontrato)
                    .HasColumnName("tipocontrato")
                    .HasMaxLength(255);

                entity.Property(e => e.UfTom)
                    .HasColumnName("uf_tom")
                    .HasMaxLength(2);

                entity.Property(e => e.ValorCofins).HasDefaultValueSql("0");

                entity.Property(e => e.ValorCsll).HasDefaultValueSql("0");

                entity.Property(e => e.ValorDeducoes).HasDefaultValueSql("0");

                entity.Property(e => e.ValorInss).HasDefaultValueSql("0");

                entity.Property(e => e.ValorIr).HasDefaultValueSql("0");

                entity.Property(e => e.ValorIss).HasDefaultValueSql("0");

                entity.Property(e => e.ValorIssRetido).HasDefaultValueSql("0");

                entity.Property(e => e.ValorLiquidoNfse).HasDefaultValueSql("0");

                entity.Property(e => e.ValorPis).HasDefaultValueSql("0");

                entity.Property(e => e.ValorServicos).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NfseParametros>(entity =>
            {
                entity.HasKey(e => e.CodigoInt)
                    .HasName("NFSe_Parametros$PrimaryKey");

                entity.ToTable("NFSe_Parametros");

                entity.HasIndex(e => e.IdentificacaoAmbiente)
                    .HasName("NFSe_Parametros$IdentificacaoAmbiente");

                entity.HasIndex(e => e.NomeFantasia)
                    .HasName("NFSe_Parametros$NF_DESTINATARIO");

                entity.Property(e => e.Bairro).HasMaxLength(50);

                entity.Property(e => e.CdUf)
                    .HasColumnName("CD_UF")
                    .HasMaxLength(255);

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(15);

                entity.Property(e => e.Certifiadora).HasMaxLength(255);

                entity.Property(e => e.Certificado).HasDefaultValueSql("''");

                entity.Property(e => e.Cnaefiscal)
                    .HasColumnName("CNAEFiscal")
                    .HasMaxLength(7)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CnpjCpf)
                    .HasColumnName("CNPJ_CPF")
                    .HasMaxLength(18)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CodigoIbge)
                    .HasColumnName("CodigoIBGE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DanfeAut).HasMaxLength(1);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EnvConf)
                    .HasColumnName("envConf")
                    .HasMaxLength(1);

                entity.Property(e => e.EnvHtml)
                    .HasColumnName("envHTML")
                    .HasMaxLength(1);

                entity.Property(e => e.Envimsm).HasColumnName("envimsm");

                entity.Property(e => e.IdentificacaoAmbiente)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'2 - Homologação'");

                entity.Property(e => e.Ie)
                    .HasColumnName("IE")
                    .HasMaxLength(40);

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasMaxLength(255);

                entity.Property(e => e.LicencaDll)
                    .HasColumnName("LicencaDLL")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Logo).HasDefaultValueSql("0");

                entity.Property(e => e.LogoMarca).HasMaxLength(255);

                entity.Property(e => e.Logradouro).HasMaxLength(60);

                entity.Property(e => e.ModelNf).HasColumnName("ModelNF");

                entity.Property(e => e.Muncipio).HasMaxLength(50);

                entity.Property(e => e.NLogra)
                    .HasColumnName("N_Logra")
                    .HasMaxLength(20);

                entity.Property(e => e.NomeFantasia)
                    .HasColumnName("Nome_Fantasia")
                    .HasMaxLength(70);

                entity.Property(e => e.Proxy)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RgTributario)
                    .HasColumnName("RG_Tributario")
                    .HasDefaultValueSql("1058");

                entity.Property(e => e.SenhaProxy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Smtp)
                    .HasColumnName("smtp")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpMail)
                    .HasColumnName("smtpMail")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpPorta)
                    .HasColumnName("smtpPorta")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpSenha)
                    .HasColumnName("smtpSenha")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpSsl)
                    .HasColumnName("smtpSSL")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpUsuario)
                    .HasColumnName("smtpUsuario")
                    .HasMaxLength(255);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .HasColumnName("SSMA_TimeStamp")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Telefone).HasMaxLength(30);

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.TipoCert).HasMaxLength(255);

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasMaxLength(2);

                entity.Property(e => e.UsuarioProxy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VersaoSchema)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WebService)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Prefeituras>(entity =>
            {
                entity.HasKey(e => e.Idpm)
                    .HasName("_prefeituras$PrimaryKey");

                entity.ToTable("_prefeituras");

                entity.Property(e => e.Idpm).HasColumnName("idpm");

                entity.Property(e => e.CdIbge).HasColumnName("cdIBGE");

                entity.Property(e => e.Logopm)
                    .HasColumnName("logopm")
                    .HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .HasColumnName("municipio")
                    .HasMaxLength(255);

                entity.Property(e => e.NfInfo)
                    .HasColumnName("nfInfo")
                    .HasMaxLength(255);

                entity.Property(e => e.NfOutInf).HasColumnName("nfOutInf");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .HasColumnName("SSMA_TimeStamp")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Registro>(entity =>
            {
                entity.HasKey(e => e.CodCliente)
                    .HasName("Registro$PrimaryKey");

                entity.HasIndex(e => e.Campanha)
                    .HasName("Registro${91E43E1A-12C5-4302-AB2C-57703C514FE6}");

                entity.HasIndex(e => e.FgAq)
                    .HasName("Registro$10_FG/AQRegistro");

                entity.HasIndex(e => e.Status)
                    .HasName("Registro$10_StatusRegistro");

                entity.HasIndex(e => e.Statusb)
                    .HasName("Registro$10_StatusBRegistro");

                entity.HasIndex(e => e.Tipo)
                    .HasName("Registro$00_ProdutosRegistro");

                entity.Property(e => e.CodCliente).HasColumnName("COD CLIENTE");

                entity.Property(e => e.AgComercial)
                    .HasColumnName("AG COMERCIAL")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Campanha).HasColumnName("CAMPANHA");

                entity.Property(e => e.Casa).HasColumnName("CASA");

                entity.Property(e => e.Conversãoaquecedor)
                    .HasColumnName("CONVERSÃOAQUECEDOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Conversãofogão)
                    .HasColumnName("CONVERSÃOFOGÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Coordenador)
                    .IsRequired()
                    .HasColumnName("COORDENADOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(20);

                entity.Property(e => e.Cups)
                    .HasColumnName("CUPS")
                    .HasMaxLength(255);

                entity.Property(e => e.DataStatus)
                    .HasColumnName("DATA STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataVenda)
                    .HasColumnName("DATA VENDA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datacadastro)
                    .HasColumnName("DATACADASTRO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FgAq).HasColumnName("FG/AQ");

                entity.Property(e => e.Marcaaquecedor)
                    .HasColumnName("MARCAAQUECEDOR")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Marcafogão)
                    .HasColumnName("MARCAFOGÃO")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Ncliente).HasColumnName("NCLIENTE");

                entity.Property(e => e.NomeESobrenome)
                    .IsRequired()
                    .HasColumnName("NOME E SOBRENOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Nsolicitacao)
                    .HasColumnName("NSOLICITACAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodo).HasColumnName("PERIODO");

                entity.Property(e => e.Procedencia).HasColumnName("PROCEDENCIA");

                entity.Property(e => e.PropCeg).HasColumnName("PROP CEG");

                entity.Property(e => e.PropGns)
                    .HasColumnName("PROP GNS")
                    .HasMaxLength(255);

                entity.Property(e => e.PropNvt).HasColumnName("PROP NVT");

                entity.Property(e => e.Propcegnzeus)
                    .HasColumnName("PROPCEGNZEUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Propnvtnzeus)
                    .HasColumnName("PROPNVTNZEUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Statusb)
                    .HasColumnName("STATUSB")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.TarifaSocial).HasColumnName("TARIFA SOCIAL");

                entity.Property(e => e.Telefone1)
                    .IsRequired()
                    .HasColumnName("TELEFONE 1")
                    .HasMaxLength(15);

                entity.Property(e => e.Telefone2)
                    .HasColumnName("TELEFONE 2")
                    .HasMaxLength(15);

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.TxInscrição).HasColumnName("TX INSCRIÇÃO");

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(255);

                entity.Property(e => e.Valorop).HasColumnName("VALOROP");

                entity.HasOne(d => d.AgComercialNavigation)
                    .WithMany(p => p.Registro)
                    .HasForeignKey(d => d.AgComercial)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Registro_Funcionários");

                entity.HasOne(d => d.CasaNavigation)
                    .WithMany(p => p.Registro)
                    .HasForeignKey(d => d.Casa)
                    .HasConstraintName("FK_Registro_11_CondEstrutura");
            });

            modelBuilder.Entity<Rj11rj45>(entity =>
            {
                entity.ToTable("RJ11RJ45");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dados).HasColumnName("DADOS");

                entity.Property(e => e.Posto)
                    .IsRequired()
                    .HasColumnName("POSTO")
                    .HasMaxLength(255);

                entity.Property(e => e.Ramal).HasColumnName("RAMAL");

                entity.Property(e => e.Telefone).HasColumnName("TELEFONE");

                entity.Property(e => e.TipoLinha)
                    .HasColumnName("TIPO LINHA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TablasGenerales>(entity =>
            {
                entity.Property(e => e.Codigo).HasMaxLength(50);

                entity.Property(e => e.NombreTabla).HasMaxLength(50);

                entity.Property(e => e.Valor).HasMaxLength(255);
            });

            modelBuilder.Entity<TblRibbons>(entity =>
            {
                entity.ToTable("tblRibbons");

                entity.Property(e => e.RibbonName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblUsuários>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("tblUsuários$PrimaryKey");

                entity.ToTable("tblUsuários");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Administrador).HasDefaultValueSql("0");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.Bloqueado).HasDefaultValueSql("0");

                entity.Property(e => e.Registros).HasDefaultValueSql("0");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tecnicos>(entity =>
            {
                entity.Property(e => e.Codigo).HasMaxLength(50);

                entity.Property(e => e.FechaAlta).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaBaja).HasColumnType("smalldatetime");

                entity.Property(e => e.NombreCompleto).HasMaxLength(50);
            });

            modelBuilder.Entity<TiDeletar>(entity =>
            {
                entity.ToTable("TI_Deletar");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Registros)
                    .HasColumnName("REGISTROS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TipoDeConta>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("Tipo de Conta$COD");

                entity.ToTable("Tipo de Conta");

                entity.HasIndex(e => e.TipoDeConta1)
                    .HasName("Tipo de Conta$Tipo de ContaTIPO DE CONTA");

                entity.Property(e => e.Cod)
                    .HasColumnName("COD")
                    .ValueGeneratedNever();

                entity.Property(e => e.TipoDeConta1)
                    .HasColumnName("TIPO DE CONTA")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipopgto)
                    .HasColumnName("TIPOPGTO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TipoDeDocumento>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("Tipo De Documento$COD");

                entity.ToTable("Tipo De Documento");

                entity.HasIndex(e => e.TipoDoc)
                    .HasName("Tipo De Documento$Tipo De DocumentoTIPO DOC");

                entity.Property(e => e.Cod)
                    .HasColumnName("COD")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO DOC")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TipoNatOp>(entity =>
            {
                entity.ToTable("_tipoNatOp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255);

                entity.Property(e => e.Des)
                    .HasColumnName("des")
                    .HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .HasColumnName("municipio")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TipoNf>(entity =>
            {
                entity.ToTable("_tipoNF");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255);

                entity.Property(e => e.Des)
                    .HasColumnName("des")
                    .HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .HasColumnName("municipio")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TipoNfregTrib>(entity =>
            {
                entity.ToTable("_tipoNFRegTrib");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255);

                entity.Property(e => e.Des)
                    .HasColumnName("des")
                    .HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .HasColumnName("municipio")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TipoNfserie>(entity =>
            {
                entity.ToTable("_tipoNFSerie");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255);

                entity.Property(e => e.Des)
                    .HasColumnName("des")
                    .HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .HasColumnName("municipio")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TipoNfstatus>(entity =>
            {
                entity.ToTable("_tipoNFStatus");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255);

                entity.Property(e => e.Des)
                    .HasColumnName("des")
                    .HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .HasColumnName("municipio")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_0000extratos>(entity =>
            {
                entity.HasKey(e => e.Código)
                    .HasName("00_00Extratos$PrimaryKey");

                entity.ToTable("00_00Extratos");

                entity.Property(e => e.Agencia).HasColumnName("AGENCIA");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Historico)
                    .HasColumnName("HISTORICO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdBanco).HasColumnName("idBanco");

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_00Areas>(entity =>
            {
                entity.ToTable("00_Areas");

                entity.HasIndex(e => e.Area)
                    .HasName("00_Areas$AREA");

                entity.HasIndex(e => e.Delegacao)
                    .HasName("00_Areas$00_Delegação00_Areas");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasColumnName("AREA")
                    .HasMaxLength(255);

                entity.Property(e => e.Delegacao).HasColumnName("DELEGACAO");

                entity.Property(e => e.Ge)
                    .HasColumnName("GE")
                    .HasMaxLength(255);

                entity.Property(e => e.Go)
                    .HasColumnName("GO")
                    .HasMaxLength(255);

                entity.HasOne(d => d.DelegacaoNavigation)
                    .WithMany(p => p._00Areas)
                    .HasForeignKey(d => d.Delegacao)
                    .HasConstraintName("FK_00_Areas_00_Delegação");
            });

            modelBuilder.Entity<_00Bairro>(entity =>
            {
                entity.ToTable("00_Bairro");

                entity.HasIndex(e => e.Area)
                    .HasName("00_Bairro$00_Areas00_Bairro");

                entity.HasIndex(e => e.Bairro)
                    .HasName("00_Bairro$00_BairroBAIRRO");

                entity.HasIndex(e => e.Loc)
                    .HasName("00_Bairro$log_bairro_loc_nu_sequencial");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.Bairro)
                    .HasColumnName("BAIRRO")
                    .HasMaxLength(255);

                entity.Property(e => e.Loc)
                    .HasColumnName("LOC")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p._00Bairro)
                    .HasForeignKey(d => d.Area)
                    .HasConstraintName("FK_00_Bairro_00_Areas");

                entity.HasOne(d => d.LocNavigation)
                    .WithMany(p => p._00Bairro)
                    .HasForeignKey(d => d.Loc)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_00_Bairro_00_Localidade");
            });

            modelBuilder.Entity<_00Caminhos>(entity =>
            {
                entity.ToTable("00_Caminhos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Caminho).HasMaxLength(255);

                entity.Property(e => e.Descrição).HasMaxLength(255);

                entity.Property(e => e.Evento).HasMaxLength(255);

                entity.Property(e => e.Grupo).HasMaxLength(2);

                entity.Property(e => e.NomeObjeto).HasMaxLength(255);

                entity.Property(e => e.Objeto).HasMaxLength(255);
            });

            modelBuilder.Entity<_00Delegação>(entity =>
            {
                entity.ToTable("00_Delegação");

                entity.HasIndex(e => e.Cliente)
                    .HasName("00_Delegação$Clientes00_Delegação");

                entity.HasIndex(e => e.Delegacao)
                    .HasName("00_Delegação$10_DelegaçãoDELEGACAO");

                entity.HasIndex(e => e.Zona)
                    .HasName("00_Delegação$00_Zona00_Delegação");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.D).HasMaxLength(255);

                entity.Property(e => e.Delegacao)
                    .IsRequired()
                    .HasColumnName("DELEGACAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Delegacaok4)
                    .HasColumnName("DELEGACAOK4")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasColumnName("ZONA");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p._00Delegação)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_00_Delegação_Clientes");

                entity.HasOne(d => d.ZonaNavigation)
                    .WithMany(p => p._00Delegação)
                    .HasForeignKey(d => d.Zona)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("00_Delegação$00_Zona00_Delegação");
            });

            modelBuilder.Entity<_00Empresa>(entity =>
            {
                entity.ToTable("00_Empresa");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apt)
                    .HasColumnName("APT")
                    .HasMaxLength(255);

                entity.Property(e => e.Bairro).HasColumnName("BAIRRO");

                entity.Property(e => e.Bloco)
                    .HasColumnName("BLOCO")
                    .HasMaxLength(255);

                entity.Property(e => e.Celular1)
                    .HasColumnName("CELULAR 1")
                    .HasMaxLength(11);

                entity.Property(e => e.Celular2)
                    .HasColumnName("CELULAR 2")
                    .HasMaxLength(11);

                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .HasMaxLength(14);

                entity.Property(e => e.Comp)
                    .HasColumnName("COMP")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.Ie)
                    .HasColumnName("IE")
                    .HasMaxLength(8);

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasMaxLength(7);

                entity.Property(e => e.Localidade).HasColumnName("LOCALIDADE");

                entity.Property(e => e.Logotipo)
                    .HasColumnName("LOGOTIPO")
                    .HasMaxLength(255);

                entity.Property(e => e.Logradouro).HasColumnName("LOGRADOURO");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(255);

                entity.Property(e => e.Observações)
                    .HasColumnName("OBSERVAÇÕES")
                    .HasMaxLength(255);

                entity.Property(e => e.Raiz)
                    .HasColumnName("RAIZ")
                    .HasMaxLength(255);

                entity.Property(e => e.RazãoSocial)
                    .HasColumnName("RAZÃO SOCIAL")
                    .HasMaxLength(255);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefone1)
                    .HasColumnName("TELEFONE 1")
                    .HasMaxLength(10);

                entity.Property(e => e.Telefone2)
                    .HasColumnName("TELEFONE 2")
                    .HasMaxLength(10);

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.HasOne(d => d.LogradouroNavigation)
                    .WithMany(p => p._00Empresa)
                    .HasForeignKey(d => d.Logradouro)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_00_Empresa_00_Logradouro");
            });

            modelBuilder.Entity<_00Estado>(entity =>
            {
                entity.ToTable("00_Estado");

                entity.HasIndex(e => e.Estado)
                    .HasName("00_Estado$00_EstadoESTADO");

                entity.HasIndex(e => e.Uf)
                    .HasName("00_Estado$EstadoUF");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_00Filial>(entity =>
            {
                entity.ToTable("00_Filial");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bairro).HasColumnName("BAIRRO");

                entity.Property(e => e.Comp)
                    .HasColumnName("COMP")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.Localidade).HasColumnName("LOCALIDADE");

                entity.Property(e => e.Logradouro).HasColumnName("LOGRADOURO");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Num).HasColumnName("NUM");

                entity.Property(e => e.Tipovia).HasColumnName("TIPOVIA");
            });

            modelBuilder.Entity<_00Localidade>(entity =>
            {
                entity.ToTable("00_Localidade");

                entity.HasIndex(e => e.Localidade)
                    .HasName("00_Localidade$00_LocalidadeLOCALIDADE");

                entity.HasIndex(e => e.Uf)
                    .HasName("00_Localidade${A2B091EA-4E5A-47D7-B105-D3097DC98722}");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ibge)
                    .HasColumnName("IBGE")
                    .HasMaxLength(255);

                entity.Property(e => e.Localidade)
                    .IsRequired()
                    .HasColumnName("LOCALIDADE")
                    .HasMaxLength(255);

                entity.Property(e => e.Municipioad)
                    .HasColumnName("MUNICIPIOAD")
                    .HasMaxLength(255);

                entity.Property(e => e.Municipiok4)
                    .HasColumnName("MUNICIPIOK4")
                    .HasMaxLength(255);

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.UfNavigation)
                    .WithMany(p => p._00Localidade)
                    .HasForeignKey(d => d.Uf)
                    .HasConstraintName("FK_00_Localidade_00_Estado");
            });

            modelBuilder.Entity<_00Logradouro>(entity =>
            {
                entity.ToTable("00_Logradouro");

                entity.HasIndex(e => e.Bairro)
                    .HasName("00_Logradouro${633DB0A6-AA7E-4DDA-BB0C-D94F048F3A10}");

                entity.HasIndex(e => e.Logradouro)
                    .HasName("00_Logradouro$00_LogradouroLOGRADOURO");

                entity.HasIndex(e => e.Tipo2)
                    .HasName("00_Logradouro${AD64DD29-D411-4DCF-B2FC-CD2610F4D8FA}");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bairro)
                    .HasColumnName("BAIRRO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(16);

                entity.Property(e => e.Complemento)
                    .HasColumnName("COMPLEMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Latitude)
                    .HasColumnName("LATITUDE")
                    .HasMaxLength(255);

                entity.Property(e => e.Local)
                    .HasColumnName("LOCAL")
                    .HasMaxLength(255);

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasColumnName("LOGRADOURO")
                    .HasMaxLength(255);

                entity.Property(e => e.Longitude)
                    .HasColumnName("LONGITUDE")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipo2).HasColumnName("TIPO2");

                entity.Property(e => e.TipoAvbr)
                    .HasColumnName("TIPO AVBR")
                    .HasMaxLength(255);

                entity.HasOne(d => d.BairroNavigation)
                    .WithMany(p => p._00Logradouro)
                    .HasForeignKey(d => d.Bairro)
                    .HasConstraintName("00_Logradouro${633DB0A6-AA7E-4DDA-BB0C-D94F048F3A10}");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p._00Logradouro)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_00_Logradouro_00_TipoLogradouro");
            });

            modelBuilder.Entity<_00Produtos>(entity =>
            {
                entity.ToTable("00_Produtos");

                entity.HasIndex(e => e.Produto)
                    .HasName("00_Produtos$10_ProdutosPRODUTO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Agrup).HasColumnName("AGRUP");

                entity.Property(e => e.Produto)
                    .IsRequired()
                    .HasColumnName("PRODUTO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_00Setores>(entity =>
            {
                entity.HasKey(e => e.Código)
                    .HasName("00_Setores$PrimaryKey");

                entity.ToTable("00_Setores");

                entity.HasIndex(e => e.Setor)
                    .HasName("00_Setores$00_SetoresSETOR");

                entity.Property(e => e.Setor)
                    .HasColumnName("SETOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_00TabelasItems>(entity =>
            {
                entity.ToTable("00_TabelasItems");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasColumnName("CAMPO")
                    .HasMaxLength(255);

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasColumnName("ITEM")
                    .HasMaxLength(255);

                entity.Property(e => e.Ordem).HasColumnName("ORDEM");

                entity.Property(e => e.Tabela).HasColumnName("TABELA");
            });

            modelBuilder.Entity<_00TipoLog2>(entity =>
            {
                entity.ToTable("00_TipoLog2");

                entity.HasIndex(e => e.Tipo2)
                    .HasName("00_TipoLog2$00_TipoLog2TIPO2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbrevCeg)
                    .HasColumnName("ABREV CEG")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipo2)
                    .HasColumnName("TIPO2")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_00TipoLogradouro>(entity =>
            {
                entity.HasKey(e => e.Tipo)
                    .HasName("00_TipoLogradouro$PrimaryKey");

                entity.ToTable("00_TipoLogradouro");

                entity.HasIndex(e => e.Obs)
                    .HasName("00_TipoLogradouro$ID CEG");

                entity.HasIndex(e => e.Tipo2)
                    .HasName("00_TipoLogradouro${52B44A5D-AE72-4F8F-95D5-7DD979496678}");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(255);

                entity.Property(e => e.AbrevCeg)
                    .HasColumnName("ABREV CEG")
                    .HasMaxLength(255);

                entity.Property(e => e.Abreviatura)
                    .IsRequired()
                    .HasColumnName("ABREVIATURA")
                    .HasMaxLength(255);

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipo2).HasColumnName("TIPO 2");

                entity.HasOne(d => d.Tipo2Navigation)
                    .WithMany(p => p._00TipoLogradouro)
                    .HasForeignKey(d => d.Tipo2)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("00_TipoLogradouro${52B44A5D-AE72-4F8F-95D5-7DD979496678}");
            });

            modelBuilder.Entity<_00TiposContrato>(entity =>
            {
                entity.ToTable("00_TiposContrato");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contrato)
                    .HasColumnName("CONTRATO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_00Zona>(entity =>
            {
                entity.ToTable("00_Zona");

                entity.HasIndex(e => e.Zona)
                    .HasName("00_Zona$00_ZonaZONA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Z).HasMaxLength(255);

                entity.Property(e => e.Zona)
                    .HasColumnName("ZONA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10BdConta>(entity =>
            {
                entity.ToTable("10_BD_CONTA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BdConta)
                    .HasColumnName("BD_CONTA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10Campanha>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("10_Campanha$PrimaryKey");

                entity.ToTable("10_Campanha");

                entity.HasIndex(e => e.Campanha)
                    .HasName("10_Campanha${AF080B46-061C-4657-A68D-3A019E71ED2D}");

                entity.HasIndex(e => e.Promoção)
                    .HasName("10_Campanha${D5D42E63-5C34-4284-A48B-728E20202F92}");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Campanha)
                    .HasColumnName("CAMPANHA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Promoção).HasColumnName("PROMOÇÃO");

                entity.HasOne(d => d.CampanhaNavigation)
                    .WithMany(p => p._10Campanha)
                    .HasForeignKey(d => d.Campanha)
                    .HasConstraintName("10_Campanha${AF080B46-061C-4657-A68D-3A019E71ED2D}");

                entity.HasOne(d => d.PromoçãoNavigation)
                    .WithMany(p => p._10Campanha)
                    .HasForeignKey(d => d.Promoção)
                    .HasConstraintName("10_Campanha${D5D42E63-5C34-4284-A48B-728E20202F92}");
            });

            modelBuilder.Entity<_10CampanhaId>(entity =>
            {
                entity.ToTable("10_Campanha_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ativa)
                    .IsRequired()
                    .HasColumnName("ATIVA")
                    .HasMaxLength(255);

                entity.Property(e => e.Descriçao)
                    .HasColumnName("DESCRIÇAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10CargasAgendadasId>(entity =>
            {
                entity.ToTable("10_CargasAgendadasID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datacargas)
                    .HasColumnName("DATACARGAS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataenvio)
                    .HasColumnName("DATAENVIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Envio)
                    .HasColumnName("ENVIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Numenvio)
                    .HasColumnName("NUMENVIO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Userenvio)
                    .HasColumnName("USERENVIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasColumnName("ZONA");
            });

            modelBuilder.Entity<_10CargasAgendadasSub>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("10_CargasAgendadasSub$PrimaryKey");

                entity.ToTable("10_CargasAgendadasSub");

                entity.HasIndex(e => e.Id)
                    .HasName("10_CargasAgendadasSub$ID");

                entity.HasIndex(e => e.Protocolonvt)
                    .HasName("10_CargasAgendadasSub$10_ClientesCEGObs10_CargasAgendadasSub");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Protocolonvt).HasColumnName("PROTOCOLONVT");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._10CargasAgendadasSub)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("10_CargasAgendadasSub$10_CargasAgendadasID10_CargasAgendadasSub");

                entity.HasOne(d => d.ProtocolonvtNavigation)
                    .WithMany(p => p._10CargasAgendadasSub)
                    .HasForeignKey(d => d.Protocolonvt)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("10_CargasAgendadasSub$10_ClientesCEGObs10_CargasAgendadasSub");
            });

            modelBuilder.Entity<_10Certificados>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("10_Certificados$PrimaryKey");

                entity.ToTable("10_Certificados");

                entity.HasIndex(e => e.Id)
                    .HasName("10_Certificados$ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p._10Certificados)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_10_Certificados_Registro");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._10Certificados)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_10_Certificados_10_CertificadosID");
            });

            modelBuilder.Entity<_10CertificadosId>(entity =>
            {
                entity.ToTable("10_CertificadosID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.Datasystem)
                    .HasColumnName("DATASYSTEM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Delegacao).HasColumnName("DELEGACAO");

                entity.Property(e => e.Usersystem)
                    .HasColumnName("USERSYSTEM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10CertificadosTemp>(entity =>
            {
                entity.ToTable("10_CertificadosTemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_10ClientesCegdetalhesN>(entity =>
            {
                entity.ToTable("10_ClientesCEGDetalhesN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Tema).HasColumnName("TEMA");
            });

            modelBuilder.Entity<_10ClientesCegobs>(entity =>
            {
                entity.ToTable("10_ClientesCEGObs");

                entity.HasIndex(e => e.Cliente)
                    .HasName("10_ClientesCEGObs${EFC9A2FA-6C46-4AF5-A16D-7877CCB7D3BE}");

                entity.HasIndex(e => e.Detalhenegativo)
                    .HasName("10_ClientesCEGObs${2CC27BC1-D32E-45F8-AF4E-4099329676F7}");

                entity.HasIndex(e => e.Protocolo)
                    .HasName("10_ClientesCEGObs$10_ClientesCEGObsPROTOCOLO");

                entity.HasIndex(e => e.Responsável)
                    .HasName("10_ClientesCEGObs${C90D34C6-3A87-4451-8834-89AD92731505}");

                entity.HasIndex(e => e.Tema)
                    .HasName("10_ClientesCEGObs${E5F201DE-1667-4464-AD20-1E579B1428EB}");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Conclusao)
                    .HasColumnName("CONCLUSAO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dataabertura)
                    .HasColumnName("DATAABERTURA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataagendada)
                    .HasColumnName("DATAAGENDADA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataconclusão)
                    .HasColumnName("DATACONCLUSÃO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datalastedit)
                    .HasColumnName("DATALASTEDIT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataservico)
                    .HasColumnName("DATASERVICO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Detalhenegativo).HasColumnName("DETALHENEGATIVO");

                entity.Property(e => e.Detalheobs).HasColumnName("DETALHEOBS");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Encarregado)
                    .HasColumnName("ENCARREGADO")
                    .HasMaxLength(255);

                entity.Property(e => e.Instalador)
                    .HasColumnName("INSTALADOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Instalador02)
                    .HasColumnName("INSTALADOR 02")
                    .HasMaxLength(255);

                entity.Property(e => e.Numos)
                    .HasColumnName("NUMOS")
                    .HasMaxLength(255);

                entity.Property(e => e.Protocolo)
                    .IsRequired()
                    .HasColumnName("PROTOCOLO")
                    .HasMaxLength(24);

                entity.Property(e => e.Responsável).HasColumnName("RESPONSÁVEL");

                entity.Property(e => e.Tema).HasColumnName("TEMA");

                entity.Property(e => e.Turno)
                    .IsRequired()
                    .HasColumnName("TURNO")
                    .HasMaxLength(255);

                entity.Property(e => e.Userabertura)
                    .HasColumnName("USERABERTURA")
                    .HasMaxLength(255);

                entity.Property(e => e.Userconclusão)
                    .HasColumnName("USERCONCLUSÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Userlastedit)
                    .HasColumnName("USERLASTEDIT")
                    .HasMaxLength(255);

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p._10ClientesCegobs)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_10_ClientesCEGObs_Registro");

                entity.HasOne(d => d.DetalhenegativoNavigation)
                    .WithMany(p => p._10ClientesCegobs)
                    .HasForeignKey(d => d.Detalhenegativo)
                    .HasConstraintName("FK_10_ClientesCEGObs_10_ClientesCEGDetalhesN");

                entity.HasOne(d => d.TemaNavigation)
                    .WithMany(p => p._10ClientesCegobs)
                    .HasForeignKey(d => d.Tema)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_10_ClientesCEGObs_10_ClientesCEGTemas");
            });

            modelBuilder.Entity<_10ClientesCegresponsável>(entity =>
            {
                entity.ToTable("10_ClientesCEGResponsável");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10ClientesCegtemas>(entity =>
            {
                entity.ToTable("10_ClientesCEGTemas");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Responsável).HasColumnName("RESPONSÁVEL");

                entity.HasOne(d => d.ResponsávelNavigation)
                    .WithMany(p => p._10ClientesCegtemas)
                    .HasForeignKey(d => d.Responsável)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_10_ClientesCEGTemas_10_ClientesCEGResponsável");
            });

            modelBuilder.Entity<_10ComissoesPgto>(entity =>
            {
                entity.ToTable("10_ComissoesPgto");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasMaxLength(255);

                entity.Property(e => e.Temp)
                    .HasColumnName("TEMP")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usersistema)
                    .HasColumnName("USERSISTEMA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10ComissoesPgtoSub>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("PK_10_ComissoesPgtoSub");

                entity.ToTable("10_ComissoesPgtoSub");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Sat)
                    .HasColumnName("SAT")
                    .HasColumnType("decimal");

                entity.Property(e => e.Valorcom)
                    .HasColumnName("VALORCOM")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p._10ComissoesPgtoSub)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_10_ComissoesPgtoSub_Registro");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._10ComissoesPgtoSub)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_10_ComissoesPgtoSub_10_ComissoesPgto");
            });

            modelBuilder.Entity<_10ConsultaZeus>(entity =>
            {
                entity.ToTable("10_ConsultaZeus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");
            });

            modelBuilder.Entity<_10ConsultaZeusB>(entity =>
            {
                entity.ToTable("10_ConsultaZeusB");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Carga)
                    .HasColumnName("CARGA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cups)
                    .HasColumnName("CUPS")
                    .HasMaxLength(255);

                entity.Property(e => e.Ncertificado)
                    .HasColumnName("NCERTIFICADO")
                    .HasMaxLength(255);

                entity.Property(e => e.Propcegnzeus)
                    .HasColumnName("PROPCEGNZEUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Propnvtnzeus)
                    .HasColumnName("PROPNVTNZEUS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10Equipamentos>(entity =>
            {
                entity.ToTable("10_Equipamentos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Equipamento)
                    .HasColumnName("EQUIPAMENTO")
                    .HasMaxLength(255);

                entity.Property(e => e.Marca)
                    .HasColumnName("MARCA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10EquipeVendas>(entity =>
            {
                entity.ToTable("10_EquipeVendas");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Agente)
                    .HasColumnName("AGENTE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Emissao)
                    .HasColumnName("EMISSAO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Lider).HasColumnName("LIDER");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_10Metas>(entity =>
            {
                entity.ToTable("10_Metas");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Meta)
                    .HasColumnName("META")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zona).HasColumnName("ZONA");
            });

            modelBuilder.Entity<_10OsServiços>(entity =>
            {
                entity.ToTable("10_OS_Serviços");

                entity.HasIndex(e => e.Protocolo)
                    .HasName("10_OS_Serviços$10_ClientesCEGObs10_OS_Serviços");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.Os).HasColumnName("OS");

                entity.Property(e => e.Protocolo).HasColumnName("PROTOCOLO");

                entity.Property(e => e.Qtde)
                    .HasColumnName("QTDE")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.ItemNavigation)
                    .WithMany(p => p._10OsServiços)
                    .HasForeignKey(d => d.Item)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_10_OS_Serviços_10_Serviços");

                entity.HasOne(d => d.P1Navigation)
                    .WithMany(p => p._10OsServiços)
                    .HasForeignKey(d => d.P1)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_10_OS_Serviços_10_ProdPgtoSub01");

                entity.HasOne(d => d.ProtocoloNavigation)
                    .WithMany(p => p._10OsServiços)
                    .HasForeignKey(d => d.Protocolo)
                    .HasConstraintName("10_OS_Serviços$10_ClientesCEGObs10_OS_Serviços");
            });

            modelBuilder.Entity<_10Osmateriais>(entity =>
            {
                entity.ToTable("10_OSMateriais");

                entity.HasIndex(e => e.Protocolo)
                    .HasName("10_OSMateriais$10_ClientesCEGObs10_OSMateriais");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Os).HasColumnName("OS");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.Property(e => e.Protocolo).HasColumnName("PROTOCOLO");

                entity.Property(e => e.Qtde)
                    .HasColumnName("QTDE")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ProtocoloNavigation)
                    .WithMany(p => p._10Osmateriais)
                    .HasForeignKey(d => d.Protocolo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("10_OSMateriais$10_ClientesCEGObs10_OSMateriais");
            });

            modelBuilder.Entity<_10Periodo>(entity =>
            {
                entity.ToTable("10_Periodo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Periodo)
                    .HasColumnName("PERIODO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10PgtoPromos>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("10_PgtoPromos$PrimaryKey");

                entity.ToTable("10_PgtoPromos");

                entity.HasIndex(e => e.Cliente)
                    .HasName("10_PgtoPromos${277B7C60-8377-42D1-A447-2500D1C289E1}");

                entity.HasIndex(e => e.Idpgto)
                    .HasName("10_PgtoPromos$IDPGTO");

                entity.HasIndex(e => new { e.Cliente, e.Promo })
                    .HasName("10_PgtoPromos$DUPLI")
                    .IsUnique();

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Idpgto)
                    .HasColumnName("IDPGTO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Promo).HasColumnName("PROMO");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p._10PgtoPromos)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("10_PgtoPromos${277B7C60-8377-42D1-A447-2500D1C289E1}");

                entity.HasOne(d => d.IdpgtoNavigation)
                    .WithMany(p => p._10PgtoPromos)
                    .HasForeignKey(d => d.Idpgto)
                    .HasConstraintName("10_PgtoPromos${3E1F80AB-0B87-4EC2-BEC8-C2C560A86348}");
            });

            modelBuilder.Entity<_10PgtoPromosId>(entity =>
            {
                entity.ToTable("10_PgtoPromos_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<_10Precert>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("10_Precert$PrimaryKey");

                entity.ToTable("10_Precert");

                entity.HasIndex(e => e.Npre)
                    .HasName("10_Precert${BBD85629-12F1-47F2-9040-3864EDFDDCEF}");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cups)
                    .HasColumnName("CUPS")
                    .HasMaxLength(255);

                entity.Property(e => e.Npre).HasColumnName("NPRE");

                entity.Property(e => e.Valorunit)
                    .HasColumnName("VALORUNIT")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p._10Precert)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_10_Precert_Registro");

                entity.HasOne(d => d.NpreNavigation)
                    .WithMany(p => p._10Precert)
                    .HasForeignKey(d => d.Npre)
                    .HasConstraintName("FK_10_Precert_10_PrecertId");
            });

            modelBuilder.Entity<_10PrecertId>(entity =>
            {
                entity.HasKey(e => e.Npre)
                    .HasName("10_PrecertId$PrimaryKey");

                entity.ToTable("10_PrecertId");

                entity.HasIndex(e => e.Municipio)
                    .HasName("10_PrecertId$00_Localidade10_PrecertId");

                entity.Property(e => e.Npre).HasColumnName("NPRE");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.Delegacao).HasColumnName("DELEGACAO");

                entity.Property(e => e.Emissao)
                    .HasColumnName("EMISSAO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Municipio).HasColumnName("MUNICIPIO");

                entity.Property(e => e.Ncertificacao)
                    .HasColumnName("NCERTIFICACAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Nf).HasColumnName("NF");

                entity.Property(e => e.Temp)
                    .HasColumnName("TEMP")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Tipocontrato)
                    .HasColumnName("TIPOCONTRATO")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalAlb)
                    .HasColumnName("TOTAL_ALB")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usersistema)
                    .HasColumnName("USERSISTEMA")
                    .HasMaxLength(255);

                entity.Property(e => e.Validada)
                    .HasColumnName("VALIDADA")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_10PrecertTemp>(entity =>
            {
                entity.ToTable("10_PrecertTemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cert)
                    .HasColumnName("CERT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cups)
                    .HasColumnName("CUPS")
                    .HasMaxLength(255);

                entity.Property(e => e.Valorunit)
                    .HasColumnName("VALORUNIT")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_10ProdPgtoId>(entity =>
            {
                entity.ToTable("10_ProdPgtoID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.DataCert)
                    .HasColumnName("DATA CERT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Desconto)
                    .HasColumnName("DESCONTO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Idconta).HasColumnName("IDCONTA");

                entity.Property(e => e.Observações)
                    .HasColumnName("OBSERVAÇÕES")
                    .HasMaxLength(255);

                entity.Property(e => e.Temp)
                    .HasColumnName("TEMP")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Totalcert)
                    .HasColumnName("TOTALCERT")
                    .HasColumnType("decimal")
                    .HasComputedColumnSql("([TOTALPROD]-[TOTALMAT])-[DESCONTO]")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Totalmat)
                    .HasColumnName("TOTALMAT")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Totalprod)
                    .HasColumnName("TOTALPROD")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usersystem)
                    .HasColumnName("USERSYSTEM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10ProdPgtoSub01>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("PK_10_ProdPgtoSub04_1");

                entity.ToTable("10_ProdPgtoSub01");

                entity.HasIndex(e => new { e.Cliente, e.Tipoprod })
                    .HasName("IX_10_ProdPgtoSub01")
                    .IsUnique();

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnName("CLIENTE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.Os).HasColumnName("OS");

                entity.Property(e => e.Tipoprod).HasColumnName("TIPOPROD");

                entity.Property(e => e.Valorprod)
                    .HasColumnName("VALORPROD")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._10ProdPgtoSub01)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_10_ProdPgtoSub01_10_ProdPgtoID");
            });

            modelBuilder.Entity<_10ProdPgtoSub02>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("PK_10_ProdPgtoSub02");

                entity.ToTable("10_ProdPgtoSub02");

                entity.HasIndex(e => e.Saidamat)
                    .HasName("IX_10_ProdPgtoSub02")
                    .IsUnique();

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Saidamat).HasColumnName("SAIDAMAT");

                entity.Property(e => e.Valormat)
                    .HasColumnName("VALORMAT")
                    .HasColumnType("decimal");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._10ProdPgtoSub02)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_10_ProdPgtoSub02_10_ProdPgtoID");

                entity.HasOne(d => d.SaidamatNavigation)
                    .WithOne(p => p._10ProdPgtoSub02)
                    .HasForeignKey<_10ProdPgtoSub02>(d => d.Saidamat)
                    .HasConstraintName("FK_10_ProdPgtoSub02_40_SaidasId");
            });

            modelBuilder.Entity<_10Promos>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("10_Promos$PrimaryKey");

                entity.ToTable("10_Promos");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Descrição)
                    .HasColumnName("DESCRIÇÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Seguimento)
                    .IsRequired()
                    .HasColumnName("SEGUIMENTO")
                    .HasMaxLength(255);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_10Protocolo>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("10_Protocolo$PrimaryKey");

                entity.ToTable("10_Protocolo");

                entity.HasIndex(e => e.Cliente)
                    .HasName("10_Protocolo${1DFD4458-13B7-4F90-9770-936414CFC122}");

                entity.HasIndex(e => e.Prot)
                    .HasName("10_Protocolo${C5F5F696-0E59-4319-AFF0-8260C30B6882}");

                entity.HasIndex(e => new { e.Cliente, e.Prop })
                    .HasName("IX_10_Protocolo")
                    .IsUnique();

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Prop).HasColumnName("PROP");

                entity.Property(e => e.Prot).HasColumnName("PROT");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p._10Protocolo)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("10_Protocolo${1DFD4458-13B7-4F90-9770-936414CFC122}");
            });

            modelBuilder.Entity<_10ProtocoloId>(entity =>
            {
                entity.ToTable("10_ProtocoloId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Delegacao).HasColumnName("DELEGACAO");

                entity.Property(e => e.Observacoes)
                    .HasColumnName("OBSERVACOES")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.Usersistema)
                    .HasColumnName("USERSISTEMA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10ProtocoloTemp>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("PK_10_PotocoloTemp");

                entity.ToTable("10_ProtocoloTemp");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Prop).HasColumnName("PROP");

                entity.Property(e => e.Prot).HasColumnName("PROT");

                entity.HasOne(d => d.ProtNavigation)
                    .WithMany(p => p._10ProtocoloTemp)
                    .HasForeignKey(d => d.Prot)
                    .HasConstraintName("FK_10_ProtocoloTemp_10_ProtocoloId");
            });

            modelBuilder.Entity<_10Serviços>(entity =>
            {
                entity.ToTable("10_Serviços");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descrição)
                    .HasColumnName("DESCRIÇÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasColumnName("ITEM")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.Valorsub)
                    .HasColumnName("VALORSUB")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_10Status>(entity =>
            {
                entity.ToTable("10_Status");

                entity.HasIndex(e => e.Status)
                    .HasName("10_Status$10_StatusSTATUS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10StatusB>(entity =>
            {
                entity.ToTable("10_StatusB");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10TarifaSocial>(entity =>
            {
                entity.ToTable("10_TarifaSocial");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TarifaSocial)
                    .HasColumnName("TARIFA_SOCIAL")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10TipoProposta>(entity =>
            {
                entity.ToTable("10_TipoProposta");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descrição)
                    .HasColumnName("DESCRIÇÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Proposta)
                    .HasColumnName("PROPOSTA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10ValorVendas>(entity =>
            {
                entity.ToTable("10_ValorVendas");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Graudif).HasColumnName("GRAUDIF");

                entity.Property(e => e.Sat)
                    .HasColumnName("SAT")
                    .HasColumnType("decimal");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.Valorvenda)
                    .HasColumnName("VALORVENDA")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_10ValoresOp>(entity =>
            {
                entity.ToTable("10_ValoresOP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Delegacao).HasColumnName("DELEGACAO");

                entity.Property(e => e.Dx).HasColumnName("DX");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.Property(e => e.Valorop)
                    .HasColumnName("VALOROP")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.DelegacaoNavigation)
                    .WithMany(p => p._10ValoresOp)
                    .HasForeignKey(d => d.Delegacao)
                    .HasConstraintName("FK_10_ValoresOP_00_Delegação");

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p._10ValoresOp)
                    .HasForeignKey(d => d.Produto)
                    .HasConstraintName("FK_10_ValoresOP_00_Produtos");
            });

            modelBuilder.Entity<_11CondEstrutura>(entity =>
            {
                entity.ToTable("11_CondEstrutura");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apt)
                    .HasColumnName("APT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bloco)
                    .HasColumnName("BLOCO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Idcond).HasColumnName("IDCOND");

                entity.HasOne(d => d.IdcondNavigation)
                    .WithMany(p => p._11CondEstrutura)
                    .HasForeignKey(d => d.Idcond)
                    .HasConstraintName("FK_11_CondEstrutura_11_Condominios");
            });

            modelBuilder.Entity<_11CondVisitas>(entity =>
            {
                entity.ToTable("11_CondVisitas");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dataagendamento)
                    .HasColumnName("DATAAGENDAMENTO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datahora)
                    .HasColumnName("DATAHORA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Idcondestrutura).HasColumnName("IDCONDESTRUTURA");

                entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");

                entity.Property(e => e.Idusuarioagendamento).HasColumnName("IDUSUARIOAGENDAMENTO");

                entity.Property(e => e.Latitude)
                    .HasColumnName("LATITUDE")
                    .HasMaxLength(255);

                entity.Property(e => e.Longitude)
                    .HasColumnName("LONGITUDE")
                    .HasMaxLength(255);

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Obsagendamento)
                    .HasColumnName("OBSAGENDAMENTO")
                    .HasColumnType("text");

                entity.Property(e => e.Resultado).HasColumnName("RESULTADO");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.Venda).HasColumnName("VENDA");
            });

            modelBuilder.Entity<_11CondVisitasTemp>(entity =>
            {
                entity.ToTable("11_CondVisitasTemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apt).HasColumnName("APT");

                entity.Property(e => e.Bloco).HasColumnName("BLOCO");

                entity.Property(e => e.Datahora)
                    .HasColumnName("DATAHORA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Idcond).HasColumnName("IDCOND");

                entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");

                entity.Property(e => e.Latitude)
                    .HasColumnName("LATITUDE")
                    .HasMaxLength(255);

                entity.Property(e => e.Longitude)
                    .HasColumnName("LONGITUDE")
                    .HasMaxLength(255);

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Resultado).HasColumnName("RESULTADO");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.Venda).HasColumnName("VENDA");
            });

            modelBuilder.Entity<_11Condominios>(entity =>
            {
                entity.ToTable("11_Condominios");

                entity.HasIndex(e => e.Instinternas)
                    .HasName("11_Condominios$11_CondominiosInst11_Condominios");

                entity.HasIndex(e => e.Logradouro)
                    .HasName("11_Condominios$00_Logradouro11_Condominios");

                entity.HasIndex(e => e.Status)
                    .HasName("11_Condominios$11_CondominiosStatus11_Condominios");

                entity.HasIndex(e => e.Statusb)
                    .HasName("11_Condominios$11_CondominiosStatusB11_Condominios");

                entity.HasIndex(e => e.Tipocontato)
                    .HasName("11_Condominios$11_CondominiosContato11_Condominios");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Celular)
                    .HasColumnName("CELULAR")
                    .HasMaxLength(11);

                entity.Property(e => e.Complemento)
                    .HasColumnName("COMPLEMENTO")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'-'");

                entity.Property(e => e.Contato)
                    .HasColumnName("CONTATO")
                    .HasMaxLength(255);

                entity.Property(e => e.Dataprev)
                    .HasColumnName("DATAPREV")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datasistema)
                    .HasColumnName("DATASISTEMA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Distrede)
                    .HasColumnName("DISTREDE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Economias)
                    .HasColumnName("ECONOMIAS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Energiaatual).HasColumnName("ENERGIAATUAL");

                entity.Property(e => e.Instinternas)
                    .HasColumnName("INSTINTERNAS")
                    .HasDefaultValueSql("45");

                entity.Property(e => e.Latitude)
                    .HasColumnName("LATITUDE")
                    .HasMaxLength(255);

                entity.Property(e => e.Logradouro).HasColumnName("LOGRADOURO");

                entity.Property(e => e.Longitude)
                    .HasColumnName("LONGITUDE")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Obra).HasColumnName("OBRA");

                entity.Property(e => e.Obs).HasColumnName("OBS");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.Property(e => e.Redeinterna)
                    .HasColumnName("REDEINTERNA")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Statusb).HasColumnName("STATUSB");

                entity.Property(e => e.Tarifasocial).HasColumnName("TARIFASOCIAL");

                entity.Property(e => e.Telefone)
                    .HasColumnName("TELEFONE")
                    .HasMaxLength(10);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("decimal");

                entity.Property(e => e.Tipocontato)
                    .HasColumnName("TIPOCONTATO")
                    .HasDefaultValueSql("46");

                entity.Property(e => e.Usersistema)
                    .HasColumnName("USERSISTEMA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<_11CondominiosDetalheN>(entity =>
            {
                entity.ToTable("11_CondominiosDetalheN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Tema).HasColumnName("TEMA");
            });

            modelBuilder.Entity<_11CondominiosObs>(entity =>
            {
                entity.ToTable("11_CondominiosObs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Conclusão)
                    .HasColumnName("CONCLUSÃO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Condominio).HasColumnName("CONDOMINIO");

                entity.Property(e => e.Dataabertura)
                    .HasColumnName("DATAABERTURA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataagendada)
                    .HasColumnName("DATAAGENDADA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataconclusão)
                    .HasColumnName("DATACONCLUSÃO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datalastedit)
                    .HasColumnName("DATALASTEDIT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Detalhenegativo).HasColumnName("DETALHENEGATIVO");

                entity.Property(e => e.Detalheobs).HasColumnName("DETALHEOBS");

                entity.Property(e => e.Protocolo)
                    .IsRequired()
                    .HasColumnName("PROTOCOLO")
                    .HasMaxLength(255);

                entity.Property(e => e.Tema).HasColumnName("TEMA");

                entity.Property(e => e.Turno)
                    .IsRequired()
                    .HasColumnName("TURNO")
                    .HasMaxLength(255);

                entity.Property(e => e.Userabertura)
                    .HasColumnName("USERABERTURA")
                    .HasMaxLength(255);

                entity.Property(e => e.Userconclusão)
                    .HasColumnName("USERCONCLUSÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Userlastedit)
                    .HasColumnName("USERLASTEDIT")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CondominioNavigation)
                    .WithMany(p => p._11CondominiosObs)
                    .HasForeignKey(d => d.Condominio)
                    .HasConstraintName("FK_11_CondominiosObs_11_Condominios");

                entity.HasOne(d => d.DetalhenegativoNavigation)
                    .WithMany(p => p._11CondominiosObs)
                    .HasForeignKey(d => d.Detalhenegativo)
                    .HasConstraintName("FK_11_CondominiosObs_11_CondominiosDetalheN");

                entity.HasOne(d => d.TemaNavigation)
                    .WithMany(p => p._11CondominiosObs)
                    .HasForeignKey(d => d.Tema)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_11_CondominiosObs_11_CondominiosTemas");
            });

            modelBuilder.Entity<_11CondominiosResponsavel>(entity =>
            {
                entity.ToTable("11_CondominiosResponsavel");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_11CondominiosTemas>(entity =>
            {
                entity.ToTable("11_CondominiosTemas");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Responsável).HasColumnName("RESPONSÁVEL");

                entity.HasOne(d => d.ResponsávelNavigation)
                    .WithMany(p => p._11CondominiosTemas)
                    .HasForeignKey(d => d.Responsável)
                    .HasConstraintName("FK_11_CondominiosTemas_11_CondominiosResponsavel");
            });

            modelBuilder.Entity<_11MotivosRej>(entity =>
            {
                entity.ToTable("11_MotivosRej");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("MOTIVO")
                    .HasMaxLength(255);

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_20Agencias>(entity =>
            {
                entity.ToTable("20_Agencias");

                entity.HasIndex(e => e.Numeroconta)
                    .HasName("20_Agencias$NUMEROCONTA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Agencia)
                    .HasColumnName("AGENCIA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dva)
                    .HasColumnName("DVA")
                    .HasMaxLength(1);

                entity.Property(e => e.Dvc)
                    .HasColumnName("DVC")
                    .HasMaxLength(1);

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Entidade).HasColumnName("ENTIDADE");

                entity.Property(e => e.Nconvenio)
                    .HasColumnName("NCONVENIO")
                    .HasMaxLength(33);

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Numeroconta)
                    .HasColumnName("NUMEROCONTA")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_20Contratos>(entity =>
            {
                entity.HasKey(e => e.Contrato)
                    .HasName("20_Contratos$PrimaryKey");

                entity.ToTable("20_Contratos");

                entity.HasIndex(e => e.Cliente)
                    .HasName("20_Contratos$Clientes20_Contratos");

                entity.HasIndex(e => e.Setor)
                    .HasName("20_Contratos$00_Setores20_Contratos");

                entity.HasIndex(e => e.Tipo)
                    .HasName("20_Contratos$00_TiposContrato20_Contratos");

                entity.HasIndex(e => e.TipoDeConta)
                    .HasName("20_Contratos$Tipo de Conta20_Contratos");

                entity.Property(e => e.Contrato).HasColumnName("CONTRATO");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasColumnName("ATIVO")
                    .HasMaxLength(255);

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.DataFim)
                    .HasColumnName("DATA FIM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataInicio)
                    .HasColumnName("DATA INICIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Descrição)
                    .HasColumnName("DESCRIÇÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Historico).HasColumnName("HISTORICO");

                entity.Property(e => e.Ngor)
                    .HasColumnName("NGOR")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nwk)
                    .HasColumnName("NWK")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Setor).HasColumnName("SETOR");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.TipoDeConta).HasColumnName("TIPO DE CONTA");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p._20Contratos)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("FK_20_Contratos_00_TiposContrato");
            });

            modelBuilder.Entity<_20EntidadesBancarias>(entity =>
            {
                entity.HasKey(e => e.Conta)
                    .HasName("20_EntidadesBancarias$PrimaryKey");

                entity.ToTable("20_EntidadesBancarias");

                entity.Property(e => e.Conta).HasColumnName("CONTA");

                entity.Property(e => e.Banco)
                    .HasColumnName("BANCO")
                    .HasMaxLength(255);

                entity.Property(e => e.Cod)
                    .IsRequired()
                    .HasColumnName("COD")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipocontae).HasColumnName("TIPOCONTAE");

                entity.Property(e => e.Tipocontas).HasColumnName("TIPOCONTAS");

                entity.Property(e => e.Uso)
                    .HasColumnName("USO")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_20EnviosBancos>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("20_EnviosBancos$PrimaryKey");

                entity.ToTable("20_EnviosBancos");

                entity.HasIndex(e => e.Conta)
                    .HasName("20_EnviosBancos$CONTA");

                entity.HasIndex(e => e.Idenvio)
                    .HasName("20_EnviosBancos$ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Baixado)
                    .HasColumnName("BAIXADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Conta).HasColumnName("CONTA");

                entity.Property(e => e.Ddatapgto)
                    .HasColumnName("DDATAPGTO")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Dinfo)
                    .HasColumnName("DINFO")
                    .HasMaxLength(40);

                entity.Property(e => e.Docorrencias)
                    .HasColumnName("DOCORRENCIAS")
                    .HasMaxLength(10);

                entity.Property(e => e.Dvalorpgto)
                    .HasColumnName("DVALORPGTO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hlote)
                    .HasColumnName("HLOTE")
                    .HasMaxLength(4);

                entity.Property(e => e.Hocorrencias)
                    .HasColumnName("HOCORRENCIAS")
                    .HasMaxLength(10);

                entity.Property(e => e.Hregistro)
                    .HasColumnName("HREGISTRO")
                    .HasMaxLength(1);

                entity.Property(e => e.Idenvio).HasColumnName("IDENVIO");

                entity.Property(e => e.Salario).HasColumnName("SALARIO");

                entity.Property(e => e.Tocorrencias)
                    .HasColumnName("TOCORRENCIAS")
                    .HasMaxLength(10);

                entity.Property(e => e.Tqtdereg)
                    .HasColumnName("TQTDEREG")
                    .HasMaxLength(9);

                entity.Property(e => e.Tvalorpgtos)
                    .HasColumnName("TVALORPGTOS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdenvioNavigation)
                    .WithMany(p => p._20EnviosBancos)
                    .HasForeignKey(d => d.Idenvio)
                    .HasConstraintName("20_EnviosBancos$20_EnviosBancosID20_EnviosBancos");
            });

            modelBuilder.Entity<_20EnviosBancosId>(entity =>
            {
                entity.ToTable("20_EnviosBancosID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Hagencia).HasColumnName("HAGENCIA");

                entity.Property(e => e.Hbanco).HasColumnName("HBANCO");

                entity.Property(e => e.Hempresa).HasColumnName("HEMPRESA");

                entity.Property(e => e.Procesado)
                    .HasColumnName("PROCESADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.T05qtdelotes)
                    .HasColumnName("T05QTDELOTES")
                    .HasMaxLength(255);

                entity.Property(e => e.T06qtderegs)
                    .HasColumnName("T06QTDEREGS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_30Anos>(entity =>
            {
                entity.HasKey(e => e.Ano)
                    .HasName("30_Anos$PrimaryKey");

                entity.ToTable("30_Anos");

                entity.Property(e => e.Ano)
                    .HasColumnName("ANO")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<_30Cargos>(entity =>
            {
                entity.ToTable("30_Cargos");

                entity.HasIndex(e => e.Setor)
                    .HasName("30_Cargos${2599BE46-910C-4D4A-8892-FFED799B0BF3}");

                entity.HasIndex(e => e.TituloFunção)
                    .HasName("30_Cargos$30_CargosTITULO (FUNÇÃO)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Agenteexterno)
                    .IsRequired()
                    .HasColumnName("AGENTEEXTERNO")
                    .HasMaxLength(255);

                entity.Property(e => e.Aso)
                    .HasColumnName("ASO")
                    .HasMaxLength(255);

                entity.Property(e => e.Blusa)
                    .HasColumnName("BLUSA")
                    .HasMaxLength(255);

                entity.Property(e => e.Bota)
                    .HasColumnName("BOTA")
                    .HasMaxLength(255);

                entity.Property(e => e.Calça)
                    .HasColumnName("CALÇA")
                    .HasMaxLength(255);

                entity.Property(e => e.Ecg)
                    .HasColumnName("ECG")
                    .HasMaxLength(255);

                entity.Property(e => e.Eeg)
                    .HasColumnName("EEG")
                    .HasMaxLength(255);

                entity.Property(e => e.Empresa)
                    .HasColumnName("EMPRESA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Filial).HasColumnName("FILIAL");

                entity.Property(e => e.GamaGt)
                    .HasColumnName("Gama Gt")
                    .HasMaxLength(255);

                entity.Property(e => e.Glicemia)
                    .HasColumnName("GLICEMIA")
                    .HasMaxLength(255);

                entity.Property(e => e.HemogramaCompleto)
                    .HasColumnName("HEMOGRAMA COMPLETO")
                    .HasMaxLength(255);

                entity.Property(e => e.RaiosXTóraxApPerfil)
                    .HasColumnName("RAIOS-X TÓRAX AP/PERFIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Salário)
                    .HasColumnName("SALÁRIO")
                    .HasColumnType("decimal");

                entity.Property(e => e.Setor).HasColumnName("SETOR");

                entity.Property(e => e.TituloFunção)
                    .IsRequired()
                    .HasColumnName("TITULO (FUNÇÃO)")
                    .HasMaxLength(255);

                entity.Property(e => e.Titulob).HasColumnName("TITULOB");

                entity.Property(e => e.Tituloceg)
                    .HasColumnName("TITULOCEG")
                    .HasMaxLength(255);

                entity.Property(e => e.Tituloigape)
                    .HasColumnName("TITULOIGAPE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p._30Cargos)
                    .HasForeignKey(d => d.Empresa)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_30_Cargos_00_Empresa");

                entity.HasOne(d => d.FilialNavigation)
                    .WithMany(p => p._30Cargos)
                    .HasForeignKey(d => d.Filial)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_30_Cargos_00_Filial");

                entity.HasOne(d => d.SetorNavigation)
                    .WithMany(p => p._30Cargos)
                    .HasForeignKey(d => d.Setor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("30_Cargos${2599BE46-910C-4D4A-8892-FFED799B0BF3}");

                entity.HasOne(d => d.TitulobNavigation)
                    .WithMany(p => p._30Cargos)
                    .HasForeignKey(d => d.Titulob)
                    .HasConstraintName("FK_30_Cargos_30_CargosB");
            });

            modelBuilder.Entity<_30CargosB>(entity =>
            {
                entity.ToTable("30_CargosB");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Orde)
                    .HasColumnName("ORDE")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_30Comerciais>(entity =>
            {
                entity.ToTable("30_Comerciais");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Expgas)
                    .HasColumnName("EXPGAS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");

                entity.Property(e => e.Produto)
                    .HasColumnName("PRODUTO")
                    .HasMaxLength(255);

                entity.Property(e => e.Qtdempresas)
                    .HasColumnName("QTDEMPRESAS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tempogas)
                    .HasColumnName("TEMPOGAS")
                    .HasMaxLength(255);

                entity.Property(e => e._1admissao)
                    .HasColumnName("1ADMISSAO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._1empresa)
                    .HasColumnName("1EMPRESA")
                    .HasMaxLength(255);

                entity.HasOne(d => d.FuncionarioNavigation)
                    .WithMany(p => p._30Comerciais)
                    .HasForeignKey(d => d.Funcionario)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_30_Comerciais_Funcionários");
            });

            modelBuilder.Entity<_30ComerciaisAreas>(entity =>
            {
                entity.ToTable("30_ComerciaisAreas");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.Comercial).HasColumnName("COMERCIAL");

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p._30ComerciaisAreas)
                    .HasForeignKey(d => d.Area)
                    .HasConstraintName("FK_30_ComerciaisAreas_00_Areas");

                entity.HasOne(d => d.ComercialNavigation)
                    .WithMany(p => p._30ComerciaisAreas)
                    .HasForeignKey(d => d.Comercial)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_30_ComerciaisAreas_30_Comerciais");
            });

            modelBuilder.Entity<_30Escolaridade>(entity =>
            {
                entity.ToTable("30_Escolaridade");

                entity.HasIndex(e => e.Escolaridade)
                    .HasName("30_Escolaridade$30_EscolaridadeESCOLARIDADE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Escolaridade)
                    .HasColumnName("ESCOLARIDADE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_30EstadoCivil>(entity =>
            {
                entity.ToTable("30_EstadoCivil");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_30FolhaTipos>(entity =>
            {
                entity.ToTable("30_FolhaTipos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Conta).HasColumnName("CONTA");

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_30FormaPgtoVtvr>(entity =>
            {
                entity.ToTable("30_FormaPgtoVTVR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Formapgto)
                    .HasColumnName("FORMAPGTO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_30Meses>(entity =>
            {
                entity.HasKey(e => e.Num)
                    .HasName("30_Meses$PrimaryKey");

                entity.ToTable("30_Meses");

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_30Ponto>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("30_Ponto$PrimaryKey");

                entity.ToTable("30_Ponto");

                entity.HasIndex(e => e.Funcionário)
                    .HasName("30_Ponto${5CE9AC3C-2401-4B57-B811-0AFC603E20A4}");

                entity.HasIndex(e => e.Id)
                    .HasName("30_Ponto$ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Diasferias)
                    .HasColumnName("DIASFERIAS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Diasfolga)
                    .HasColumnName("DIASFOLGA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Diastrabalhados)
                    .HasColumnName("DIASTRABALHADOS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Faltasinjust)
                    .HasColumnName("FALTASINJUST")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Faltasjust)
                    .HasColumnName("FALTASJUST")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Funcionário).HasColumnName("FUNCIONÁRIO");

                entity.Property(e => e.H100)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.H50)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.H70)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._30Ponto)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("30_Ponto${7A973716-E38A-4C15-9312-25C078BCB1EA}");
            });

            modelBuilder.Entity<_30PontoId>(entity =>
            {
                entity.ToTable("30_PontoID");

                entity.HasIndex(e => e.Ano)
                    .HasName("30_PontoID$30_Anos30_PontoID");

                entity.HasIndex(e => e.Empresa)
                    .HasName("30_PontoID$00_Empresa30_PontoID");

                entity.HasIndex(e => e.Filial)
                    .HasName("30_PontoID$00_Filial30_PontoID");

                entity.HasIndex(e => e.Mes)
                    .HasName("30_PontoID$30_Meses30_PontoID");

                entity.HasIndex(e => new { e.Id, e.Ano, e.Mes, e.Empresa, e.Filial })
                    .HasName("30_PontoID$DUPLI")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Filial).HasColumnName("FILIAL");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.HasOne(d => d.AnoNavigation)
                    .WithMany(p => p._30PontoId)
                    .HasForeignKey(d => d.Ano)
                    .HasConstraintName("30_PontoID${A24BE175-F5D3-491A-9459-BFE1A861FDD1}");

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p._30PontoId)
                    .HasForeignKey(d => d.Empresa)
                    .HasConstraintName("30_PontoID$00_Empresa30_PontoID");

                entity.HasOne(d => d.FilialNavigation)
                    .WithMany(p => p._30PontoId)
                    .HasForeignKey(d => d.Filial)
                    .HasConstraintName("30_PontoID$00_Filial30_PontoID");
            });

            modelBuilder.Entity<_30PontoPgto>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("30_PontoPgto$PrimaryKey");

                entity.ToTable("30_PontoPgto");

                entity.HasIndex(e => e.Funcionário)
                    .HasName("30_PontoPgto${D910E21D-0EB9-4AE0-BC3C-7ECC306C56B3}");

                entity.HasIndex(e => e.Id)
                    .HasName("30_PontoPgto$ID");

                entity.HasIndex(e => e.Idconta)
                    .HasName("30_PontoPgto$IDCONTA");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Funcionário).HasColumnName("FUNCIONÁRIO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Idconta).HasColumnName("IDCONTA");

                entity.Property(e => e.Vr)
                    .HasColumnName("VR")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Vrvalor)
                    .HasColumnName("VRVALOR")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Vt)
                    .HasColumnName("VT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Vtvalor)
                    .HasColumnName("VTVALOR")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._30PontoPgto)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("30_PontoPgto${00B3C1C7-144D-40DE-90A3-D0A94D593675}");
            });

            modelBuilder.Entity<_30PontoPgtoId>(entity =>
            {
                entity.ToTable("30_PontoPgtoID");

                entity.HasIndex(e => e.Ano)
                    .HasName("30_PontoPgtoID$30_Anos30_PontoPgtoID");

                entity.HasIndex(e => e.Empresa)
                    .HasName("30_PontoPgtoID$00_Empresa30_PontoPgtoID");

                entity.HasIndex(e => e.Filial)
                    .HasName("30_PontoPgtoID$00_Filial30_PontoPgtoID");

                entity.HasIndex(e => e.Mes)
                    .HasName("30_PontoPgtoID$30_Meses30_PontoPgtoID");

                entity.HasIndex(e => new { e.Id, e.Ano, e.Mes, e.Empresa, e.Filial })
                    .HasName("30_PontoPgtoID$DUPLI")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataaprova)
                    .HasColumnName("DATAAPROVA")
                    .HasMaxLength(255);

                entity.Property(e => e.Datavto)
                    .HasColumnName("DATAVTO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Filial).HasColumnName("FILIAL");

                entity.Property(e => e.Formapgto).HasColumnName("FORMAPGTO");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Procesada)
                    .HasColumnName("PROCESADA")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.Totalpedido)
                    .HasColumnName("TOTALPEDIDO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Useraprova)
                    .HasColumnName("USERAPROVA")
                    .HasMaxLength(255);

                entity.HasOne(d => d.AnoNavigation)
                    .WithMany(p => p._30PontoPgtoId)
                    .HasForeignKey(d => d.Ano)
                    .HasConstraintName("30_PontoPgtoID$30_Anos30_PontoPgtoID");

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p._30PontoPgtoId)
                    .HasForeignKey(d => d.Empresa)
                    .HasConstraintName("30_PontoPgtoID$00_Empresa30_PontoPgtoID");

                entity.HasOne(d => d.FilialNavigation)
                    .WithMany(p => p._30PontoPgtoId)
                    .HasForeignKey(d => d.Filial)
                    .HasConstraintName("30_PontoPgtoID$00_Filial30_PontoPgtoID");

                entity.HasOne(d => d.FormapgtoNavigation)
                    .WithMany(p => p._30PontoPgtoId)
                    .HasForeignKey(d => d.Formapgto)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_30_PontoPgtoID_30_FormaPgtoVTVR");

                entity.HasOne(d => d.MesNavigation)
                    .WithMany(p => p._30PontoPgtoId)
                    .HasForeignKey(d => d.Mes)
                    .HasConstraintName("30_PontoPgtoID$30_Meses30_PontoPgtoID");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p._30PontoPgtoId)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_30_PontoPgtoID_30_VTVR");
            });

            modelBuilder.Entity<_30Salarios>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("30_Salarios$PrimaryKey");

                entity.ToTable("30_Salarios");

                entity.HasIndex(e => e.Funcionario)
                    .HasName("30_Salarios${2CA88C1A-BBB2-42F5-99B5-17414015B2BC}");

                entity.HasIndex(e => e.Idconta)
                    .HasName("30_Salarios$IDCONTA");

                entity.HasIndex(e => e.Idfolha)
                    .HasName("30_Salarios$IDFOLHA");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");

                entity.Property(e => e.Idconta).HasColumnName("IDCONTA");

                entity.Property(e => e.Idfolha).HasColumnName("IDFOLHA");

                entity.Property(e => e.Salario)
                    .HasColumnName("SALARIO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdfolhaNavigation)
                    .WithMany(p => p._30Salarios)
                    .HasForeignKey(d => d.Idfolha)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("30_Salarios${344155F5-0013-4729-8176-BEB7F88039F0}");
            });

            modelBuilder.Entity<_30SalariosId>(entity =>
            {
                entity.ToTable("30_SalariosID");

                entity.HasIndex(e => e.Ano)
                    .HasName("30_SalariosID${9BDE97F1-8EC1-4E6B-8692-F3069DF03C0E}");

                entity.HasIndex(e => e.Empresa)
                    .HasName("30_SalariosID$00_Empresa30_SalariosID");

                entity.HasIndex(e => e.Mes)
                    .HasName("30_SalariosID${A5F2A3A5-C56C-4228-93D6-694DFA129F43}");

                entity.HasIndex(e => e.Tipo)
                    .HasName("30_SalariosID${569E03FE-E5B6-45E4-8835-3602BE3527C6}");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Datadoc)
                    .HasColumnName("DATADOC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datapgto)
                    .HasColumnName("DATAPGTO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datasystem)
                    .HasColumnName("DATASYSTEM")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Folha)
                    .HasColumnName("FOLHA")
                    .HasColumnType("decimal");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Observacoes)
                    .HasColumnName("OBSERVACOES")
                    .HasMaxLength(255);

                entity.Property(e => e.Procesada)
                    .HasColumnName("PROCESADA")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.Tipopgto).HasColumnName("TIPOPGTO");

                entity.Property(e => e.Usersystem)
                    .HasColumnName("USERSYSTEM")
                    .HasMaxLength(255);

                entity.HasOne(d => d.AnoNavigation)
                    .WithMany(p => p._30SalariosId)
                    .HasForeignKey(d => d.Ano)
                    .HasConstraintName("30_SalariosID${9BDE97F1-8EC1-4E6B-8692-F3069DF03C0E}");

                entity.HasOne(d => d.MesNavigation)
                    .WithMany(p => p._30SalariosId)
                    .HasForeignKey(d => d.Mes)
                    .HasConstraintName("30_SalariosID${A5F2A3A5-C56C-4228-93D6-694DFA129F43}");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p._30SalariosId)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("30_SalariosID${569E03FE-E5B6-45E4-8835-3602BE3527C6}");
            });

            modelBuilder.Entity<_30SalariosTemp>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("30_SalariosTemp$PrimaryKey");

                entity.ToTable("30_SalariosTemp");

                entity.HasIndex(e => new { e.Idfolha, e.Contadorid })
                    .HasName("30_SalariosTemp$Dupli")
                    .IsUnique();

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Contadorid)
                    .IsRequired()
                    .HasColumnName("CONTADORID")
                    .HasMaxLength(255);

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Idfolha)
                    .IsRequired()
                    .HasColumnName("IDFOLHA");

                entity.Property(e => e.Salariobruto)
                    .HasColumnName("SALARIOBRUTO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Salarioliquido)
                    .HasColumnName("SALARIOLIQUIDO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdfolhaNavigation)
                    .WithMany(p => p._30SalariosTemp)
                    .HasForeignKey(d => d.Idfolha)
                    .HasConstraintName("FK_30_SalariosTemp_30_SalariosID");
            });

            modelBuilder.Entity<_30SodexoParametros>(entity =>
            {
                entity.ToTable("30_SodexoParametros");

                entity.HasIndex(e => e.Empresa)
                    .HasName("30_SodexoParametros$00_Empresa30_SodexoParametros");

                entity.HasIndex(e => e.Filial)
                    .HasName("30_SodexoParametros$00_Filial30_SodexoParametros");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Depnome)
                    .HasColumnName("DEPNOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Depnum)
                    .HasColumnName("DEPNUM")
                    .HasMaxLength(255);

                entity.Property(e => e.Depresp)
                    .HasColumnName("DEPRESP")
                    .HasMaxLength(255);

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Filial).HasColumnName("FILIAL");

                entity.Property(e => e.Matricula)
                    .HasColumnName("MATRICULA")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p._30SodexoParametros)
                    .HasForeignKey(d => d.Empresa)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("30_SodexoParametros$00_Empresa30_SodexoParametros");

                entity.HasOne(d => d.FilialNavigation)
                    .WithMany(p => p._30SodexoParametros)
                    .HasForeignKey(d => d.Filial)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("30_SodexoParametros$00_Filial30_SodexoParametros");
            });

            modelBuilder.Entity<_30TiposContaBancaria>(entity =>
            {
                entity.ToTable("30_TiposContaBancaria");

                entity.HasIndex(e => e.Tipoconta)
                    .HasName("30_TiposContaBancaria$30_TiposContaBancariaTIPOCONTA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descrição)
                    .HasColumnName("DESCRIÇÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipoconta)
                    .HasColumnName("TIPOCONTA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_30Vtvr>(entity =>
            {
                entity.ToTable("30_VTVR");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<_30Vtvrtipos>(entity =>
            {
                entity.ToTable("30_VTVRTipos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codsodexo)
                    .HasColumnName("CODSODEXO")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_40Centros>(entity =>
            {
                entity.ToTable("40_Centros");

                entity.HasIndex(e => e.Centro)
                    .HasName("40_Centros$40_CentrosCENTRO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Centro)
                    .HasColumnName("CENTRO")
                    .HasMaxLength(255);

                entity.Property(e => e.Descrição)
                    .HasColumnName("DESCRIÇÃO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_40Clase>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("40_Clase$PrimaryKey");

                entity.ToTable("40_Clase");

                entity.HasIndex(e => e.Clase)
                    .HasName("40_Clase$CLASE")
                    .IsUnique();

                entity.Property(e => e.Clase)
                    .IsRequired()
                    .HasColumnName("CLASE")
                    .HasMaxLength(255);

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Produnico)
                    .HasColumnName("PRODUNICO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_40Cotacao>(entity =>
            {
                entity.HasKey(e => e.Codprod)
                    .HasName("40_Cotacao$PrimaryKey");

                entity.ToTable("40_Cotacao");

                entity.HasIndex(e => e.Idcotacao)
                    .HasName("40_Cotacao$IDCOTACAO");

                entity.HasIndex(e => e.Produtoceg)
                    .HasName("40_Cotacao$40_Produtos40_Cotacao");

                entity.HasIndex(e => e.Unid)
                    .HasName("40_Cotacao$UNID");

                entity.Property(e => e.Codprod).HasColumnName("CODPROD");

                entity.Property(e => e.Descproduto)
                    .HasColumnName("DESCPRODUTO")
                    .HasMaxLength(255);

                entity.Property(e => e.Idcotacao)
                    .HasColumnName("IDCOTACAO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Produtoceg).HasColumnName("PRODUTOCEG");

                entity.Property(e => e.Qtde)
                    .HasColumnName("QTDE")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Unid).HasColumnName("UNID");

                entity.Property(e => e.Valor1)
                    .HasColumnName("VALOR1")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Valor2)
                    .HasColumnName("VALOR2")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Valor3)
                    .HasColumnName("VALOR3")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Valor4)
                    .HasColumnName("VALOR4")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdcotacaoNavigation)
                    .WithMany(p => p._40Cotacao)
                    .HasForeignKey(d => d.Idcotacao)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("40_Cotacao${12E7A255-3E2F-4700-9010-CCB1CE62D1CF}");

                entity.HasOne(d => d.ProdutocegNavigation)
                    .WithMany(p => p._40Cotacao)
                    .HasForeignKey(d => d.Produtoceg)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("40_Cotacao$40_Produtos40_Cotacao");

                entity.HasOne(d => d.Un)
                    .WithMany(p => p._40Cotacao)
                    .HasForeignKey(d => d.Unid)
                    .HasConstraintName("40_Cotacao${7F9B6952-6C65-43A7-B30E-B6D8B2EA6C31}");
            });

            modelBuilder.Entity<_40CotacaoId>(entity =>
            {
                entity.ToTable("40_Cotacao_ID");

                entity.HasIndex(e => e.Obra)
                    .HasName("40_Cotacao_ID$50_ProjetosRedeRamal40_Cotacao_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Conta).HasColumnName("CONTA");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Formapgto1)
                    .HasColumnName("FORMAPGTO1")
                    .HasMaxLength(255);

                entity.Property(e => e.Formapgto2)
                    .HasColumnName("FORMAPGTO2")
                    .HasMaxLength(255);

                entity.Property(e => e.Formapgto3)
                    .HasColumnName("FORMAPGTO3")
                    .HasMaxLength(255);

                entity.Property(e => e.Formapgto4)
                    .HasColumnName("FORMAPGTO4")
                    .HasMaxLength(255);

                entity.Property(e => e.Fornecedor1)
                    .IsRequired()
                    .HasColumnName("FORNECEDOR1")
                    .HasMaxLength(255);

                entity.Property(e => e.Fornecedor2)
                    .HasColumnName("FORNECEDOR2")
                    .HasMaxLength(255);

                entity.Property(e => e.Fornecedor3)
                    .HasColumnName("FORNECEDOR3")
                    .HasMaxLength(255);

                entity.Property(e => e.Fornecedor4)
                    .HasColumnName("FORNECEDOR4")
                    .HasMaxLength(255);

                entity.Property(e => e.Fornecedorproposto)
                    .HasColumnName("FORNECEDORPROPOSTO")
                    .HasMaxLength(255);

                entity.Property(e => e.Obra).HasColumnName("OBRA");

                entity.Property(e => e.Obs1)
                    .HasColumnName("OBS1")
                    .HasMaxLength(255);

                entity.Property(e => e.Obs2)
                    .HasColumnName("OBS2")
                    .HasMaxLength(255);

                entity.Property(e => e.Obs3)
                    .HasColumnName("OBS3")
                    .HasMaxLength(255);

                entity.Property(e => e.Obs4)
                    .HasColumnName("OBS4")
                    .HasMaxLength(255);

                entity.Property(e => e.Orcamentofornecedor1).HasColumnName("ORCAMENTOFORNECEDOR1");

                entity.Property(e => e.Orcamentofornecedor2).HasColumnName("ORCAMENTOFORNECEDOR2");

                entity.Property(e => e.Orcamentofornecedor3).HasColumnName("ORCAMENTOFORNECEDOR3");

                entity.Property(e => e.Orcamentofornecedor4).HasColumnName("ORCAMENTOFORNECEDOR4");

                entity.Property(e => e.Peticaoceg).HasColumnName("PETICAOCEG");

                entity.Property(e => e.Prazo1)
                    .HasColumnName("PRAZO1")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Prazo2)
                    .HasColumnName("PRAZO2")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Prazo3)
                    .HasColumnName("PRAZO3")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Prazo4)
                    .HasColumnName("PRAZO4")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_40EstoqueMinimo>(entity =>
            {
                entity.ToTable("40_EstoqueMinimo");

                entity.HasIndex(e => e.Centro)
                    .HasName("40_EstoqueMinimo${96CE32BE-8378-483C-B94D-49EDD05F82E9}");

                entity.HasIndex(e => e.Produto)
                    .HasName("40_EstoqueMinimo$40_Produtos40_EstoqueMinimo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Centro).HasColumnName("CENTRO");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.Property(e => e.Qtde)
                    .HasColumnName("QTDE")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CentroNavigation)
                    .WithMany(p => p._40EstoqueMinimo)
                    .HasForeignKey(d => d.Centro)
                    .HasConstraintName("40_EstoqueMinimo${96CE32BE-8378-483C-B94D-49EDD05F82E9}");

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p._40EstoqueMinimo)
                    .HasForeignKey(d => d.Produto)
                    .HasConstraintName("40_EstoqueMinimo$40_Produtos40_EstoqueMinimo");
            });

            modelBuilder.Entity<_40Familia>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("40_Familia$PrimaryKey");

                entity.ToTable("40_Familia");

                entity.HasIndex(e => e.Clase)
                    .HasName("40_Familia${9F15A885-0C72-4AB6-B941-9608FE37B0F2}");

                entity.HasIndex(e => e.Grupo)
                    .HasName("40_Familia${BF9F63AF-28A5-4273-AF6C-57AC43CC4140}");

                entity.Property(e => e.Clase).HasColumnName("CLASE");

                entity.Property(e => e.Familia)
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(38)
                    .HasComputedColumnSql("'FAMILIA'+' ')+CONVERT([nvarchar],[Cod]")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.HasOne(d => d.ClaseNavigation)
                    .WithMany(p => p._40Familia)
                    .HasForeignKey(d => d.Clase)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("40_Familia${9F15A885-0C72-4AB6-B941-9608FE37B0F2}");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p._40Familia)
                    .HasForeignKey(d => d.Grupo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("40_Familia${BF9F63AF-28A5-4273-AF6C-57AC43CC4140}");
            });

            modelBuilder.Entity<_40Grupo>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("40_Grupo$PrimaryKey");

                entity.ToTable("40_Grupo");

                entity.HasIndex(e => e.Grupo)
                    .HasName("40_Grupo$40_TabelaFamiliaFAMILIA");

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Grupo)
                    .IsRequired()
                    .HasColumnName("GRUPO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_40Interna>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("40_Interna$PrimaryKey");

                entity.ToTable("40_Interna");

                entity.HasIndex(e => e.Interna)
                    .HasName("40_Interna${71509ACA-89DE-4452-BF87-DAD527AB5248}");

                entity.HasIndex(e => new { e.Interna, e.Produto })
                    .HasName("40_Interna$NÃO DUPLI")
                    .IsUnique();

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Interna)
                    .IsRequired()
                    .HasColumnName("INTERNA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");

                entity.HasOne(d => d.InternaNavigation)
                    .WithMany(p => p._40Interna)
                    .HasForeignKey(d => d.Interna)
                    .HasConstraintName("40_Interna${71509ACA-89DE-4452-BF87-DAD527AB5248}");
            });

            modelBuilder.Entity<_40InternaId>(entity =>
            {
                entity.ToTable("40_Interna_ID");

                entity.HasIndex(e => e.Centro)
                    .HasName("40_Interna_ID$40_Centros40_Interna_ID");

                entity.HasIndex(e => e.Setor)
                    .HasName("40_Interna_ID$00_Setores40_Interna_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Centro).HasColumnName("CENTRO");

                entity.Property(e => e.Datadevolucao)
                    .HasColumnName("DATADEVOLUCAO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataentrega)
                    .HasColumnName("DATAENTREGA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Quementrega)
                    .IsRequired()
                    .HasColumnName("QUEMENTREGA")
                    .HasMaxLength(255);

                entity.Property(e => e.Quemrecebe).HasColumnName("QUEMRECEBE");

                entity.Property(e => e.Setor).HasColumnName("SETOR");

                entity.HasOne(d => d.CentroNavigation)
                    .WithMany(p => p._40InternaId)
                    .HasForeignKey(d => d.Centro)
                    .HasConstraintName("40_Interna_ID${20C157A7-94A6-4DAE-AB9F-1972F115AA4C}");

                entity.HasOne(d => d.SetorNavigation)
                    .WithMany(p => p._40InternaId)
                    .HasForeignKey(d => d.Setor)
                    .HasConstraintName("40_Interna_ID$00_Setores40_Interna_ID");
            });

            modelBuilder.Entity<_40Local>(entity =>
            {
                entity.ToTable("40_Local");

                entity.HasIndex(e => e.Localização)
                    .HasName("40_Local$40_Localização40_Local");

                entity.HasIndex(e => e.Produto)
                    .HasName("40_Local$40_Produtos40_Local");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Localização).HasColumnName("LOCALIZAÇÃO");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.HasOne(d => d.LocalizaçãoNavigation)
                    .WithMany(p => p._40Local)
                    .HasForeignKey(d => d.Localização)
                    .HasConstraintName("40_Local$40_Localização40_Local");

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p._40Local)
                    .HasForeignKey(d => d.Produto)
                    .HasConstraintName("40_Local$40_Produtos40_Local");
            });

            modelBuilder.Entity<_40Localização>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("40_Localização$PrimaryKey");

                entity.ToTable("40_Localização");

                entity.HasIndex(e => new { e.Centro, e.Localizacao })
                    .HasName("IX_40_Localização$DUPLI")
                    .IsUnique();

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Centro).HasColumnName("CENTRO");

                entity.Property(e => e.Descriçao)
                    .HasColumnName("DESCRIÇAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Localizacao)
                    .IsRequired()
                    .HasColumnName("LOCALIZACAO")
                    .HasMaxLength(6);

                entity.HasOne(d => d.CentroNavigation)
                    .WithMany(p => p._40Localização)
                    .HasForeignKey(d => d.Centro)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_40_Localização_40_Centros");
            });

            modelBuilder.Entity<_40Parceiros>(entity =>
            {
                entity.ToTable("40_Parceiros");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apt)
                    .HasColumnName("APT")
                    .HasMaxLength(255);

                entity.Property(e => e.Bairro)
                    .HasColumnName("BAIRRO")
                    .HasMaxLength(255);

                entity.Property(e => e.Bloco)
                    .HasColumnName("BLOCO")
                    .HasMaxLength(255);

                entity.Property(e => e.Celular1)
                    .HasColumnName("CELULAR 1")
                    .HasMaxLength(255);

                entity.Property(e => e.Celular2)
                    .HasColumnName("CELULAR 2")
                    .HasMaxLength(255);

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(255);

                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .HasMaxLength(255);

                entity.Property(e => e.Comp)
                    .HasColumnName("COMP")
                    .HasMaxLength(255);

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Endereço)
                    .HasColumnName("ENDEREÇO")
                    .HasMaxLength(255);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(255);

                entity.Property(e => e.Observações)
                    .HasColumnName("OBSERVAÇÕES")
                    .HasMaxLength(255);

                entity.Property(e => e.Parceiro)
                    .IsRequired()
                    .HasColumnName("PARCEIRO")
                    .HasMaxLength(255);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefone1)
                    .HasColumnName("TELEFONE 1")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefone2)
                    .HasColumnName("TELEFONE 2")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_40Pedidos>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("40_Pedidos$PrimaryKey");

                entity.ToTable("40_Pedidos");

                entity.HasIndex(e => e.Pedido)
                    .HasName("40_Pedidos$40_PedidosId40_Pedidos");

                entity.HasIndex(e => e.Produto)
                    .HasName("40_Pedidos$40_Produtos40_Pedidos");

                entity.HasIndex(e => new { e.Pedido, e.Produto })
                    .HasName("40_Pedidos$ID PEDIDO")
                    .IsUnique();

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Pedido).HasColumnName("PEDIDO");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.Property(e => e.Quantidade)
                    .HasColumnName("QUANTIDADE")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("SUBTOTAL")
                    .HasColumnType("decimal")
                    .HasComputedColumnSql("CONVERT([decimal](18,2),[VALORPROD]*[QUANTIDADE])")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Valorprod)
                    .HasColumnName("VALORPROD")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.PedidoNavigation)
                    .WithMany(p => p._40Pedidos)
                    .HasForeignKey(d => d.Pedido)
                    .HasConstraintName("40_Pedidos$40_PedidosId40_Pedidos");

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p._40Pedidos)
                    .HasForeignKey(d => d.Produto)
                    .HasConstraintName("40_Pedidos$40_Produtos40_Pedidos");
            });

            modelBuilder.Entity<_40PedidosId>(entity =>
            {
                entity.ToTable("40_PedidosId");

                entity.HasIndex(e => e.Centro)
                    .HasName("40_PedidosId${5FFA9E19-0DB6-4E03-A9CB-86E9AE160E9C}");

                entity.HasIndex(e => e.Cotação)
                    .HasName("40_PedidosId${8AD3BF94-0C5F-4F98-9567-71A5D8C68ADD}");

                entity.HasIndex(e => e.Fornecedor)
                    .HasName("40_PedidosId${BA76BD34-7C97-4B20-A04D-53CC726EF1C8}");

                entity.HasIndex(e => e.Setor)
                    .HasName("40_PedidosId$00_Setores40_PedidosId");

                entity.HasIndex(e => e.Solicitante)
                    .HasName("40_PedidosId${6529D90F-A951-4ECE-BA1F-99645D08E5C2}");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aprovado)
                    .HasColumnName("APROVADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Autorizacao)
                    .HasColumnName("AUTORIZACAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Centro).HasColumnName("CENTRO");

                entity.Property(e => e.Cotação).HasColumnName("COTAÇÃO");

                entity.Property(e => e.Dataaprovado)
                    .HasColumnName("DATAAPROVADO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataentrada)
                    .HasColumnName("DATAENTRADA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datapedido)
                    .HasColumnName("DATAPEDIDO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datasistema)
                    .HasColumnName("DATASISTEMA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datasolicitacao)
                    .HasColumnName("DATASOLICITACAO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fornecedor).HasColumnName("FORNECEDOR");

                entity.Property(e => e.Fornecedorescolhido)
                    .HasColumnName("FORNECEDORESCOLHIDO")
                    .HasMaxLength(255);

                entity.Property(e => e.Obra).HasColumnName("OBRA");

                entity.Property(e => e.Observacao)
                    .HasColumnName("OBSERVACAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Reprovado)
                    .HasColumnName("REPROVADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Setor).HasColumnName("SETOR");

                entity.Property(e => e.Solicitante).HasColumnName("SOLICITANTE");

                entity.Property(e => e.Transfer)
                    .HasColumnName("TRANSFER")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Usuariosistema)
                    .HasColumnName("USUARIOSISTEMA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_40PeticaoTemp>(entity =>
            {
                entity.ToTable("40_PeticaoTemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.Itemceg)
                    .HasColumnName("ITEMCEG")
                    .HasMaxLength(255);

                entity.Property(e => e.Qtde)
                    .HasColumnName("QTDE")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Cot)
                    .WithMany(p => p._40PeticaoTemp)
                    .HasForeignKey(d => d.Cotid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_40_PeticaoTemp_40_Cotacao_ID");
            });

            modelBuilder.Entity<_40Produtos>(entity =>
            {
                entity.ToTable("40_Produtos");

                entity.HasIndex(e => e.Familia)
                    .HasName("40_Produtos$40_Familia40_Produtos");

                entity.HasIndex(e => e.Produto)
                    .HasName("40_Produtos$40_ProdutosPRODUTO");

                entity.HasIndex(e => e.Unidmedida)
                    .HasName("40_Produtos$40_Unidades40_Produtos");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(255);

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Familia).HasColumnName("FAMILIA");

                entity.Property(e => e.Patrimonio).HasColumnName("PATRIMONIO");

                entity.Property(e => e.Produto)
                    .IsRequired()
                    .HasColumnName("PRODUTO")
                    .HasMaxLength(255);

                entity.Property(e => e.Unidmedida).HasColumnName("UNIDMEDIDA");

                entity.HasOne(d => d.FamiliaNavigation)
                    .WithMany(p => p._40Produtos)
                    .HasForeignKey(d => d.Familia)
                    .HasConstraintName("FK_40_Produtos_40_Familia");
            });

            modelBuilder.Entity<_40Saidas>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("PK_40_Saidas_1");

                entity.ToTable("40_Saidas");

                entity.HasIndex(e => e.Pedido)
                    .HasName("40_Saidas$40_SaidasId40_Saidas");

                entity.HasIndex(e => e.Produto)
                    .HasName("40_Saidas$40_Produtos40_Saidas");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Pedido).HasColumnName("PEDIDO");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.Property(e => e.Quantidade)
                    .HasColumnName("QUANTIDADE")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("SUBTOTAL")
                    .HasColumnType("decimal")
                    .HasComputedColumnSql("CONVERT([decimal](18,2),[VALORPROD]*[QUANTIDADE])")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Valorprod)
                    .HasColumnName("VALORPROD")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.PedidoNavigation)
                    .WithMany(p => p._40Saidas)
                    .HasForeignKey(d => d.Pedido)
                    .HasConstraintName("40_Saidas$40_SaidasId40_Saidas");

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p._40Saidas)
                    .HasForeignKey(d => d.Produto)
                    .HasConstraintName("40_Saidas$40_Produtos40_Saidas");
            });

            modelBuilder.Entity<_40SaidasId>(entity =>
            {
                entity.HasKey(e => e.Saida)
                    .HasName("40_SaidasId$PrimaryKey");

                entity.ToTable("40_SaidasId");

                entity.HasIndex(e => e.Centro)
                    .HasName("40_SaidasId$40_Centros40_SaidasId");

                entity.HasIndex(e => e.Cliente)
                    .HasName("40_SaidasId$40_Parceiros40_SaidasId");

                entity.HasIndex(e => e.Setor)
                    .HasName("40_SaidasId$00_Setores40_SaidasId");

                entity.Property(e => e.Saida).HasColumnName("SAIDA");

                entity.Property(e => e.Centro).HasColumnName("CENTRO");

                entity.Property(e => e.Clase).HasColumnName("CLASE");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Datasaida)
                    .HasColumnName("DATASAIDA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datasistema)
                    .HasColumnName("DATASISTEMA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Desconto)
                    .HasColumnName("DESCONTO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Obra).HasColumnName("OBRA");

                entity.Property(e => e.Observacoes)
                    .HasColumnName("OBSERVACOES")
                    .HasMaxLength(255);

                entity.Property(e => e.Pgtoemp).HasColumnName("PGTOEMP");

                entity.Property(e => e.Setor).HasColumnName("SETOR");

                entity.Property(e => e.Totalsaida)
                    .HasColumnName("TOTALSAIDA")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transfer)
                    .HasColumnName("TRANSFER")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("USUARIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Usuariosistema)
                    .HasColumnName("USUARIOSISTEMA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_40Unidades>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("40_Unidades$PrimaryKey");

                entity.ToTable("40_Unidades");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Unidade)
                    .HasColumnName("UNIDADE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50CroquiCentroContabil>(entity =>
            {
                entity.ToTable("50_CroquiCentroContabil");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Id2)
                    .HasColumnName("ID2")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome2)
                    .IsRequired()
                    .HasColumnName("NOME2")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50Croquis>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("50_Croquis$PrimaryKey");

                entity.ToTable("50_Croquis");

                entity.HasIndex(e => e.Centrocontabil)
                    .HasName("50_Croquis$50_CroquiCentroContabil50_Croquis");

                entity.HasIndex(e => e.Desenhista)
                    .HasName("50_Croquis$Funcionários50_Croquis");

                entity.HasIndex(e => e.Encarregado)
                    .HasName("50_Croquis$Funcionários50_Croquis1");

                entity.HasIndex(e => e.Projeto)
                    .HasName("50_Croquis${B421C0F2-5E27-409F-B64F-99968C58C094}");

                entity.HasIndex(e => e.Soldador)
                    .HasName("50_Croquis${8E997914-FD8D-42DA-94E8-2936404526BE}");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.Centrocontabil).HasColumnName("CENTROCONTABIL");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Desenhista).HasColumnName("DESENHISTA");

                entity.Property(e => e.Encanador).HasColumnName("ENCANADOR");

                entity.Property(e => e.Encarregado).HasColumnName("ENCARREGADO");

                entity.Property(e => e.Maquinasolda)
                    .IsRequired()
                    .HasColumnName("MAQUINASOLDA")
                    .HasMaxLength(255);

                entity.Property(e => e.Numcroqui)
                    .HasColumnName("NUMCROQUI")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasMaxLength(255);

                entity.Property(e => e.Projeto).HasColumnName("PROJETO");

                entity.Property(e => e.Soldador).HasColumnName("SOLDADOR");

                entity.Property(e => e.Trecho)
                    .HasColumnName("TRECHO")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CentrocontabilNavigation)
                    .WithMany(p => p._50Croquis)
                    .HasForeignKey(d => d.Centrocontabil)
                    .HasConstraintName("50_Croquis$50_CroquiCentroContabil50_Croquis");

                entity.HasOne(d => d.DesenhistaNavigation)
                    .WithMany(p => p._50CroquisDesenhistaNavigation)
                    .HasForeignKey(d => d.Desenhista)
                    .HasConstraintName("FK_50_Croquis_Funcionários1");

                entity.HasOne(d => d.EncanadorNavigation)
                    .WithMany(p => p._50CroquisEncanadorNavigation)
                    .HasForeignKey(d => d.Encanador)
                    .HasConstraintName("FK_50_Croquis_Funcionários");

                entity.HasOne(d => d.EncarregadoNavigation)
                    .WithMany(p => p._50CroquisEncarregadoNavigation)
                    .HasForeignKey(d => d.Encarregado)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_50_Croquis_Funcionários3");

                entity.HasOne(d => d.SoldadorNavigation)
                    .WithMany(p => p._50CroquisSoldadorNavigation)
                    .HasForeignKey(d => d.Soldador)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_50_Croquis_Funcionários2");
            });

            modelBuilder.Entity<_50CroquisImport>(entity =>
            {
                entity.ToTable("50_CroquisImport");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.Conta)
                    .HasColumnName("CONTA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cqnum)
                    .HasColumnName("CQNUM")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Desenhista)
                    .HasColumnName("DESENHISTA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Encanador)
                    .HasColumnName("ENCANADOR")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Encarregado)
                    .HasColumnName("ENCARREGADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Maquina)
                    .HasColumnName("MAQUINA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Obra)
                    .HasColumnName("OBRA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Soldador)
                    .HasColumnName("SOLDADOR")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_50CroquisSubImport>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("50_CroquisSubImport$PrimaryKey");

                entity.ToTable("50_CroquisSubImport");

                entity.HasIndex(e => e.Cqid)
                    .HasName("50_CroquisSubImport$CQID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Cqid)
                    .HasColumnName("CQID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasMaxLength(255);

                entity.Property(e => e.Lote)
                    .HasColumnName("LOTE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Med)
                    .HasColumnName("MED")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Qtde)
                    .HasColumnName("QTDE")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tipreg)
                    .HasColumnName("TIPREG")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_50DiasTrabalho>(entity =>
            {
                entity.ToTable("50_DiasTrabalho");

                entity.HasIndex(e => e.Data)
                    .HasName("50_DiasTrabalho$DATA")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<_50DiasTrabalhoMo>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("50_DiasTrabalhoMO$PrimaryKey");

                entity.ToTable("50_DiasTrabalhoMO");

                entity.HasIndex(e => e.Coddia)
                    .HasName("50_DiasTrabalhoMO$ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Coddia).HasColumnName("CODDIA");

                entity.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");

                entity.HasOne(d => d.CoddiaNavigation)
                    .WithMany(p => p._50DiasTrabalhoMo)
                    .HasForeignKey(d => d.Coddia)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("50_DiasTrabalhoMO$50_DiasTrabalhoObras50_DiasTrabalhoMO");
            });

            modelBuilder.Entity<_50DiasTrabalhoObras>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("50_DiasTrabalhoObras$PrimaryKey");

                entity.ToTable("50_DiasTrabalhoObras");

                entity.HasIndex(e => e.Id)
                    .HasName("50_DiasTrabalhoObras$ID");

                entity.HasIndex(e => e.Obra)
                    .HasName("50_DiasTrabalhoObras$50_ProjetosRedeRamal50_DiasTrabalhoObras");

                entity.HasIndex(e => new { e.Cod, e.Id, e.Obra })
                    .HasName("IX_50_DiasTrabalhoObras");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Obra).HasColumnName("OBRA");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._50DiasTrabalhoObras)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("50_DiasTrabalhoObras$50_DiasTrabalho50_DiasTrabalhoObras");
            });

            modelBuilder.Entity<_50ItemsRedeRamal>(entity =>
            {
                entity.HasKey(e => e.Item)
                    .HasName("50_ItemsRedeRamal$PrimaryKey");

                entity.ToTable("50_ItemsRedeRamal");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasMaxLength(15);

                entity.Property(e => e.Ccontabil)
                    .HasColumnName("CCONTABIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(255);

                entity.Property(e => e.D3).HasDefaultValueSql("0");

                entity.Property(e => e.Descrição)
                    .IsRequired()
                    .HasColumnName("DESCRIÇÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Diametro).HasColumnName("DIAMETRO");

                entity.Property(e => e.Knvt).HasColumnName("KNVT");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.Tipocontrato).HasColumnName("TIPOCONTRATO");

                entity.Property(e => e.Ud).HasColumnName("UD");

                entity.Property(e => e.Unidade)
                    .IsRequired()
                    .HasColumnName("UNIDADE")
                    .HasMaxLength(10);

                entity.Property(e => e.Uso)
                    .IsRequired()
                    .HasColumnName("USO")
                    .HasMaxLength(3);

                entity.Property(e => e.Valorbase)
                    .HasColumnName("VALORBASE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Valornvt)
                    .HasColumnName("VALORNVT")
                    .HasComputedColumnSql("[VALORBASE]*[KNVT]")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Valorsub)
                    .HasColumnName("VALORSUB")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.TipocontratoNavigation)
                    .WithMany(p => p._50ItemsRedeRamal)
                    .HasForeignKey(d => d.Tipocontrato)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_50_ItemsRedeRamal_00_TiposContrato");
            });

            modelBuilder.Entity<_50ItemsTipo>(entity =>
            {
                entity.ToTable("50_ItemsTipo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50ItemsValor>(entity =>
            {
                entity.ToTable("50_ItemsValor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cargo).HasColumnName("CARGO");

                entity.Property(e => e.Conta).HasColumnName("CONTA");

                entity.Property(e => e.Tipoitem).HasColumnName("TIPOITEM");

                entity.Property(e => e.Valoritem)
                    .HasColumnName("VALORITEM")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_50LotesPlanoTeste>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("50_LotesPlanoTeste$PrimaryKey");

                entity.ToTable("50_LotesPlanoTeste");

                entity.HasIndex(e => e.Croqui)
                    .HasName("50_LotesPlanoTeste$50_Croquis50_LotesPlanoTeste");

                entity.HasIndex(e => e.Id)
                    .HasName("50_LotesPlanoTeste$ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Croqui).HasColumnName("CROQUI");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CroquiNavigation)
                    .WithMany(p => p._50LotesPlanoTeste)
                    .HasForeignKey(d => d.Croqui)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("50_LotesPlanoTeste$50_Croquis50_LotesPlanoTeste");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._50LotesPlanoTeste)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("50_LotesPlanoTeste$50_LotesPlanoTesteID50_LotesPlanoTeste");
            });

            modelBuilder.Entity<_50LotesPlanoTesteId>(entity =>
            {
                entity.ToTable("50_LotesPlanoTesteID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datasystem)
                    .HasColumnName("DATASYSTEM")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Nret)
                    .HasColumnName("NRET")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Obra).HasColumnName("OBRA");

                entity.Property(e => e.Usersystem)
                    .HasColumnName("USERSYSTEM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50LotesPvc>(entity =>
            {
                entity.ToTable("50_LotesPVC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lote).HasColumnName("LOTE");
            });

            modelBuilder.Entity<_50Metas>(entity =>
            {
                entity.ToTable("50_Metas");

                entity.HasIndex(e => new { e.Ano, e.Mes, e.Obra })
                    .HasName("50_Metas$DUPLI")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Ccontabil)
                    .IsRequired()
                    .HasColumnName("CCONTABIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Diametro)
                    .HasColumnName("DIAMETRO")
                    .HasColumnType("decimal");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Metrosrede)
                    .HasColumnName("METROSREDE")
                    .HasColumnType("decimal");

                entity.Property(e => e.Obra).HasColumnName("OBRA");

                entity.Property(e => e.Ramais)
                    .HasColumnName("RAMAIS")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_50ObrasResponsávelObs>(entity =>
            {
                entity.ToTable("50_ObrasResponsávelObs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50OpempreiteirasId>(entity =>
            {
                entity.ToTable("50_OPEmpreiteirasID");

                entity.HasIndex(e => e.Idconta)
                    .HasName("50_OPEmpreiteirasID$IDCONTA");

                entity.HasIndex(e => e.Obra)
                    .HasName("50_OPEmpreiteirasID$50_ProjetosRedeRamal50_OPEmpreiteirasID1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Desconto)
                    .HasColumnName("DESCONTO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Idconta).HasColumnName("IDCONTA");

                entity.Property(e => e.Obra).HasColumnName("OBRA");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasMaxLength(255);

                entity.Property(e => e.Temp)
                    .HasColumnName("TEMP")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Totalcert)
                    .HasColumnName("TOTALCERT")
                    .HasColumnType("decimal")
                    .HasComputedColumnSql("([TOTALPROD]-[TOTALMAT])-[DESCONTO]")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Totalmat)
                    .HasColumnName("TOTALMAT")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Totalprod)
                    .HasColumnName("TOTALPROD")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usersystem)
                    .HasColumnName("USERSYSTEM")
                    .HasMaxLength(255);

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p._50OpempreiteirasId)
                    .HasForeignKey(d => d.Empresa)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_50_OPEmpreiteirasID_40_Parceiros");
            });

            modelBuilder.Entity<_50OpempreiteirasSub01>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("50_OPEmpreiteiras$PrimaryKey");

                entity.ToTable("50_OPEmpreiteirasSub01");

                entity.HasIndex(e => e.Iddesenv)
                    .HasName("50_OPEmpreiteiras$IDDESENV");

                entity.HasIndex(e => e.Idop)
                    .HasName("50_OPEmpreiteiras$IDOP");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Iddesenv).HasColumnName("IDDESENV");

                entity.Property(e => e.Idop).HasColumnName("IDOP");

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdopNavigation)
                    .WithMany(p => p._50OpempreiteirasSub01)
                    .HasForeignKey(d => d.Idop)
                    .HasConstraintName("FK_50_OPEmpreiteiras_50_OPEmpreiteirasID");
            });

            modelBuilder.Entity<_50OpempreiteirasSub02>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("PK_50_OPEmpreiteirasSub02");

                entity.ToTable("50_OPEmpreiteirasSub02");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Saidamat).HasColumnName("SAIDAMAT");

                entity.Property(e => e.Valormat)
                    .HasColumnName("VALORMAT")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._50OpempreiteirasSub02)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_50_OPEmpreiteirasSub02_50_OPEmpreiteirasID");

                entity.HasOne(d => d.SaidamatNavigation)
                    .WithMany(p => p._50OpempreiteirasSub02)
                    .HasForeignKey(d => d.Saidamat)
                    .HasConstraintName("FK_50_OPEmpreiteirasSub02_40_SaidasId");
            });

            modelBuilder.Entity<_50OpproducaoA>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("PK_50_OPProducaoA");

                entity.ToTable("50_OPProducaoA");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");

                entity.Property(e => e.Idop).HasColumnName("IDOP");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.Totalitem)
                    .HasColumnName("TOTALITEM")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.FuncionarioNavigation)
                    .WithMany(p => p._50OpproducaoA)
                    .HasForeignKey(d => d.Funcionario)
                    .HasConstraintName("FK_50_OPProducaoA_Funcionários");

                entity.HasOne(d => d.IdopNavigation)
                    .WithMany(p => p._50OpproducaoA)
                    .HasForeignKey(d => d.Idop)
                    .HasConstraintName("FK_50_OPProducaoA_50_OPProducaoID");
            });

            modelBuilder.Entity<_50OpproducaoB>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("PK_50_OPProducaoB");

                entity.ToTable("50_OPProducaoB");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");

                entity.Property(e => e.Idop).HasColumnName("IDOP");

                entity.Property(e => e.Motivodesconto)
                    .HasColumnName("MOTIVODESCONTO")
                    .HasMaxLength(255);

                entity.Property(e => e.Totaldesconto)
                    .HasColumnName("TOTALDESCONTO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.FuncionarioNavigation)
                    .WithMany(p => p._50OpproducaoB)
                    .HasForeignKey(d => d.Funcionario)
                    .HasConstraintName("FK_50_OPProducaoB_Funcionários");

                entity.HasOne(d => d.IdopNavigation)
                    .WithMany(p => p._50OpproducaoB)
                    .HasForeignKey(d => d.Idop)
                    .HasConstraintName("FK_50_OPProducaoB_50_OPProducaoID");
            });

            modelBuilder.Entity<_50OpproducaoId>(entity =>
            {
                entity.ToTable("50_OPProducaoID");

                entity.HasIndex(e => e.Idconta)
                    .HasName("50_OPProducaoID$IDCONTA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Idconta).HasColumnName("IDCONTA");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasMaxLength(255);

                entity.Property(e => e.Temp)
                    .HasColumnName("TEMP")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Totaldesc)
                    .HasColumnName("TOTALDESC")
                    .HasColumnType("decimal");

                entity.Property(e => e.Totalop)
                    .HasColumnName("TOTALOP")
                    .HasComputedColumnSql("CONVERT([float],[TOTALPROD])-CONVERT([float],[TOTALDESC])")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Totalprod)
                    .HasColumnName("TOTALPROD")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usercreate)
                    .HasColumnName("USERCREATE")
                    .HasMaxLength(255);

                entity.Property(e => e.Usersave)
                    .HasColumnName("USERSAVE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50PlanoTesteMat>(entity =>
            {
                entity.ToTable("50_PlanoTesteMat");

                entity.HasIndex(e => e.Material)
                    .HasName("50_PlanoTesteMat$40_Produtos50_PlanoTesteMat");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Diametro).HasColumnName("DIAMETRO");

                entity.Property(e => e.Material).HasColumnName("MATERIAL");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.HasOne(d => d.MaterialNavigation)
                    .WithMany(p => p._50PlanoTesteMat)
                    .HasForeignKey(d => d.Material)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("50_PlanoTesteMat$40_Produtos50_PlanoTesteMat");
            });

            modelBuilder.Entity<_50Precert>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("50_Precert$PrimaryKey");

                entity.ToTable("50_Precert");

                entity.HasIndex(e => e.Anterior)
                    .HasName("50_Precert$UNID");

                entity.HasIndex(e => e.Atual)
                    .HasName("50_Precert$ANTERIOR");

                entity.HasIndex(e => e.Desconto)
                    .HasName("50_Precert${15BB6AF0-BD68-4179-ACAD-8CA6C3BB0528}");

                entity.HasIndex(e => e.Idpre)
                    .HasName("50_Precert$IDPRE");

                entity.HasIndex(e => e.Item)
                    .HasName("50_Precert$IDDESENVOLVIMENTO");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Anterior)
                    .HasColumnName("ANTERIOR")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Atual)
                    .HasColumnName("ATUAL")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Croqui).HasColumnName("CROQUI");

                entity.Property(e => e.Desconto)
                    .HasColumnName("DESCONTO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Idpre).HasColumnName("IDPRE");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasColumnName("ITEM")
                    .HasMaxLength(10);

                entity.Property(e => e.Numreg)
                    .HasColumnName("NUMREG")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal")
                    .HasComputedColumnSql("round([ATUAL]+[ANTERIOR],(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Valornvt)
                    .HasColumnName("VALORNVT")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CroquiNavigation)
                    .WithMany(p => p._50Precert)
                    .HasForeignKey(d => d.Croqui)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_50_Precert_50_Croquis");

                entity.HasOne(d => d.DescontoNavigation)
                    .WithMany(p => p._50Precert)
                    .HasForeignKey(d => d.Desconto)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("50_Precert${15BB6AF0-BD68-4179-ACAD-8CA6C3BB0528}");

                entity.HasOne(d => d.IdpreNavigation)
                    .WithMany(p => p._50Precert)
                    .HasForeignKey(d => d.Idpre)
                    .HasConstraintName("FK_50_Precert_50_PrecertId");
            });

            modelBuilder.Entity<_50PrecertId>(entity =>
            {
                entity.ToTable("50_PrecertId");

                entity.HasIndex(e => e.Centrocontabil)
                    .HasName("50_PrecertId$50_CroquiCentroContabil50_PrecertId");

                entity.HasIndex(e => e.Codprojeto)
                    .HasName("50_PrecertId${4F61C6D6-8773-44C1-A610-CFEE5B031F90}");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acrescimo)
                    .HasColumnName("ACRESCIMO")
                    .HasColumnType("decimal");

                entity.Property(e => e.Acrescimonum)
                    .HasColumnName("ACRESCIMONUM")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.Atual)
                    .HasColumnName("ATUAL")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Atualantecipo)
                    .HasColumnName("ATUALANTECIPO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centrocontabil).HasColumnName("CENTROCONTABIL");

                entity.Property(e => e.Codprojeto).HasColumnName("CODPROJETO");

                entity.Property(e => e.Delegacao).HasColumnName("DELEGACAO");

                entity.Property(e => e.Emissao)
                    .HasColumnName("EMISSAO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Ncertificacao)
                    .HasColumnName("NCERTIFICACAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Ncroquis)
                    .HasColumnName("NCROQUIS")
                    .HasMaxLength(255);

                entity.Property(e => e.Nf).HasColumnName("NF");

                entity.Property(e => e.Nseq2)
                    .HasColumnName("NSEQ2")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nsequencial)
                    .HasColumnName("NSEQUENCIAL")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Temp)
                    .HasColumnName("TEMP")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TipoDeContrato).HasColumnName("TIPO DE CONTRATO");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalAlb)
                    .HasColumnName("TOTAL_ALB")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Totalantecipo)
                    .HasColumnName("TOTALANTECIPO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CentrocontabilNavigation)
                    .WithMany(p => p._50PrecertId)
                    .HasForeignKey(d => d.Centrocontabil)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("50_PrecertId$50_CroquiCentroContabil50_PrecertId");

                entity.HasOne(d => d.DelegacaoNavigation)
                    .WithMany(p => p._50PrecertId)
                    .HasForeignKey(d => d.Delegacao)
                    .HasConstraintName("FK_50_PrecertId_00_Delegação");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p._50PrecertId)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_50_PrecertId_50_PrecertTipo");
            });

            modelBuilder.Entity<_50PrecertTipo>(entity =>
            {
                entity.ToTable("50_PrecertTipo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50ProcertAcres>(entity =>
            {
                entity.ToTable("50_ProcertAcres");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<_50ProjetoDescricao>(entity =>
            {
                entity.ToTable("50_ProjetoDescricao");

                entity.HasIndex(e => e.Descricao)
                    .HasName("50_ProjetoDescricao$50_ProjetoDescricaoDESCRICAO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50ProjetoDesenvolvimento>(entity =>
            {
                entity.ToTable("50_ProjetoDesenvolvimento");

                entity.HasIndex(e => e.Croqui)
                    .HasName("50_ProjetoDesenvolvimento$50_Croquis50_ProjetoDesenvolvimento");

                entity.HasIndex(e => e.Item)
                    .HasName("50_ProjetoDesenvolvimento$50_ProjetoDesenvolvimentoITEM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Croqui).HasColumnName("CROQUI");

                entity.Property(e => e.Desconto)
                    .HasColumnName("DESCONTO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasColumnName("ITEM")
                    .HasMaxLength(15);

                entity.Property(e => e.Medant)
                    .HasColumnName("MEDANT")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Meddia)
                    .HasColumnName("MEDDIA")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Medtotal)
                    .HasColumnName("MEDTOTAL")
                    .HasColumnType("decimal")
                    .HasComputedColumnSql("round([MEDANT]+[MEDDIA],(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.CroquiNavigation)
                    .WithMany(p => p._50ProjetoDesenvolvimento)
                    .HasForeignKey(d => d.Croqui)
                    .HasConstraintName("50_ProjetoDesenvolvimento$50_Croquis50_ProjetoDesenvolvimento");

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p._50ProjetoDesenvolvimento)
                    .HasForeignKey(d => d.Empresa)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_50_ProjetoDesenvolvimento_40_Parceiros");

                entity.HasOne(d => d.ItemNavigation)
                    .WithMany(p => p._50ProjetoDesenvolvimento)
                    .HasForeignKey(d => d.Item)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_50_ProjetoDesenvolvimento_50_ItemsRedeRamal");
            });

            modelBuilder.Entity<_50ProjetoLicenciamento>(entity =>
            {
                entity.ToTable("50_ProjetoLicenciamento");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50ProjetoMateriais>(entity =>
            {
                entity.ToTable("50_ProjetoMateriais");

                entity.HasIndex(e => e.Croqui)
                    .HasName("50_ProjetoMateriais$50_Croquis50_ProjetoMateriais");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Croqui).HasColumnName("CROQUI");

                entity.Property(e => e.Lote).HasColumnName("LOTE");

                entity.Property(e => e.Qtde)
                    .HasColumnName("QTDE")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CroquiNavigation)
                    .WithMany(p => p._50ProjetoMateriais)
                    .HasForeignKey(d => d.Croqui)
                    .HasConstraintName("50_ProjetoMateriais$50_Croquis50_ProjetoMateriais");
            });

            modelBuilder.Entity<_50ProjetoNatureza>(entity =>
            {
                entity.ToTable("50_ProjetoNatureza");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50ProjetoServiços>(entity =>
            {
                entity.ToTable("50_ProjetoServiços");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cert)
                    .HasColumnName("CERT")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50ProjetoStatus>(entity =>
            {
                entity.ToTable("50_ProjetoStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50ProjetoTipo>(entity =>
            {
                entity.ToTable("50_ProjetoTipo");

                entity.HasIndex(e => e.Tipo)
                    .HasName("50_ProjetoTipo$50_ProjetoTipoTIPO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50ProjetosMetragem>(entity =>
            {
                entity.ToTable("50_ProjetosMetragem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Conta).HasColumnName("CONTA");

                entity.Property(e => e.Diametro).HasColumnName("DIAMETRO");

                entity.Property(e => e.Metragem)
                    .HasColumnName("METRAGEM")
                    .HasColumnType("decimal");

                entity.Property(e => e.Projeto).HasColumnName("PROJETO");

                entity.HasOne(d => d.ContaNavigation)
                    .WithMany(p => p._50ProjetosMetragem)
                    .HasForeignKey(d => d.Conta)
                    .HasConstraintName("FK_50_ProjetosMetragem_50_CroquiCentroContabil");

                entity.HasOne(d => d.DiametroNavigation)
                    .WithMany(p => p._50ProjetosMetragem)
                    .HasForeignKey(d => d.Diametro)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_50_ProjetosMetragem_50_Tubos");
            });

            modelBuilder.Entity<_50ProjetosRedeRamalDetalheN>(entity =>
            {
                entity.ToTable("50_ProjetosRedeRamalDetalheN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Tema).HasColumnName("TEMA");
            });

            modelBuilder.Entity<_50ProjetosRedeRamalObs>(entity =>
            {
                entity.ToTable("50_ProjetosRedeRamalObs");

                entity.HasIndex(e => e.Detalhenegativo)
                    .HasName("50_ProjetosRedeRamalObs${C33E427B-AD38-4092-A5B3-EEF9E61CA017}");

                entity.HasIndex(e => e.Projeto)
                    .HasName("50_ProjetosRedeRamalObs$50_ProjetosRedeRamal50_ProjetosRedeRamalObs");

                entity.HasIndex(e => e.Tema)
                    .HasName("50_ProjetosRedeRamalObs${C5F45407-F206-437D-97A5-997125D020E6}");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Conclusão)
                    .HasColumnName("CONCLUSÃO")
                    .HasDefaultValueSql("16");

                entity.Property(e => e.Dataabertura)
                    .HasColumnName("DATAABERTURA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataagendada)
                    .HasColumnName("DATAAGENDADA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dataconclusão)
                    .HasColumnName("DATACONCLUSÃO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Datalastedit)
                    .HasColumnName("DATALASTEDIT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Detalhenegativo).HasColumnName("DETALHENEGATIVO");

                entity.Property(e => e.Detalheobs).HasColumnName("DETALHEOBS");

                entity.Property(e => e.Projeto).HasColumnName("PROJETO");

                entity.Property(e => e.Protocolo)
                    .IsRequired()
                    .HasColumnName("PROTOCOLO")
                    .HasMaxLength(24);

                entity.Property(e => e.Tema).HasColumnName("TEMA");

                entity.Property(e => e.Userabertura)
                    .HasColumnName("USERABERTURA")
                    .HasMaxLength(255);

                entity.Property(e => e.Userconclusão)
                    .HasColumnName("USERCONCLUSÃO")
                    .HasMaxLength(255);

                entity.Property(e => e.Userlastedit)
                    .HasColumnName("USERLASTEDIT")
                    .HasMaxLength(255);

                entity.HasOne(d => d.DetalhenegativoNavigation)
                    .WithMany(p => p._50ProjetosRedeRamalObs)
                    .HasForeignKey(d => d.Detalhenegativo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_50_ProjetosRedeRamalObs_50_ProjetosRedeRamalDetalheN");

                entity.HasOne(d => d.TemaNavigation)
                    .WithMany(p => p._50ProjetosRedeRamalObs)
                    .HasForeignKey(d => d.Tema)
                    .HasConstraintName("FK_50_ProjetosRedeRamalObs_50_ProjetosRedeRamalTema");
            });

            modelBuilder.Entity<_50ProjetosRedeRamalTema>(entity =>
            {
                entity.ToTable("50_ProjetosRedeRamalTema");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Responsável).HasColumnName("RESPONSÁVEL");
            });

            modelBuilder.Entity<_50Tubos>(entity =>
            {
                entity.ToTable("50_Tubos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Diametro)
                    .HasColumnName("DIAMETRO")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Polegadas)
                    .HasColumnName("POLEGADAS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_50TubosTipo>(entity =>
            {
                entity.ToTable("50_TubosTipo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_60CertificacaoEquipamentos>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("60_CertificacaoEquipamentos$PrimaryKey");

                entity.ToTable("60_CertificacaoEquipamentos");

                entity.HasIndex(e => e.Certificacao)
                    .HasName("60_CertificacaoEquipamentos$ID2");

                entity.HasIndex(e => e.Conta)
                    .HasName("60_CertificacaoEquipamentos$CONTA");

                entity.HasIndex(e => e.Id)
                    .HasName("60_CertificacaoEquipamentos$ID");

                entity.HasIndex(e => e.IdCaixa)
                    .HasName("60_CertificacaoEquipamentos$IdCaixa");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Agencia)
                    .HasColumnName("AGENCIA")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Aliquota)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bairro)
                    .HasColumnName("BAIRRO")
                    .HasMaxLength(255);

                entity.Property(e => e.BaseCalculo)
                    .HasComputedColumnSql("round([VALORCERT]-(([VALORCERT]*[ValorDeducoesPercent])/CONVERT([float],(100))+([VALORCERT]*[ValorDescontoIncPercent])/CONVERT([float],(100))),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CdmunicipioTom)
                    .HasColumnName("cdmunicipio_tom")
                    .HasMaxLength(10);

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(255);

                entity.Property(e => e.Certificacao)
                    .HasColumnName("CERTIFICACAO")
                    .HasMaxLength(255);

                entity.Property(e => e.CnpjPrest)
                    .HasColumnName("Cnpj_prest")
                    .HasMaxLength(255);

                entity.Property(e => e.CodigoCnae).HasMaxLength(255);

                entity.Property(e => e.CodigoMunicipio).HasMaxLength(255);

                entity.Property(e => e.CodigoTributacaoMunicipio).HasMaxLength(20);

                entity.Property(e => e.Complemento)
                    .HasColumnName("COMPLEMENTO")
                    .HasMaxLength(255);

                entity.Property(e => e.Conta).HasColumnName("CONTA");

                entity.Property(e => e.Contrato)
                    .HasColumnName("CONTRATO")
                    .HasColumnType("decimal");

                entity.Property(e => e.Cpfcnpj)
                    .HasColumnName("CPFCNPJ")
                    .HasMaxLength(255);

                entity.Property(e => e.DataDoc)
                    .HasColumnName("DATA DOC")
                    .HasMaxLength(255);

                entity.Property(e => e.DataMovimento).HasColumnType("smalldatetime");

                entity.Property(e => e.DataVencimento).HasColumnType("smalldatetime");

                entity.Property(e => e.DescontoCondicionado)
                    .HasComputedColumnSql("round(([VALORCERT]*[DescontoCondicionadoPercent])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.DescontoCondicionadoPercent)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descontos)
                    .HasColumnName("DESCONTOS")
                    .HasComputedColumnSql("round(([VALORCERT]*[ValorDescontoIncPercent])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Discriminacao)
                    .HasMaxLength(380)
                    .HasComputedColumnSql("left((((((((('SERVIÇO NO ENDEREÇO :'+' ')+isnull([ENDEREÇOCLIENTE],''))+', ')+'MUNICIPIO DE')+' ')+isnull([MUNICIPIO],''))+', ')+isnull([UF],''))+space((95)),(95))+left(('NºCLIENTE : '+CONVERT([nvarchar],isnull([NUMCLIENTE],(0))))+space((95)),(95)))+left(('NºCERTIFICAÇÃO : '+isnull([CERTIFICACAO],''))+space((95)),(95)))+left(('SERVIÇO: '+isnull([NOMEOS],''))+space((95)),(95")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Empresa)
                    .HasColumnName("EMPRESA")
                    .HasMaxLength(255);

                entity.Property(e => e.Endereçocliente)
                    .HasColumnName("ENDEREÇOCLIENTE")
                    .HasMaxLength(255);

                entity.Property(e => e.Filial)
                    .HasColumnName("FILIAL")
                    .HasMaxLength(255);

                entity.Property(e => e.Histórico)
                    .HasColumnName("HISTÓRICO")
                    .HasMaxLength(255);

                entity.Property(e => e.IcNf)
                    .HasColumnName("ic_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCaixa).HasMaxLength(255);

                entity.Property(e => e.ImPrest)
                    .HasColumnName("IM_prest")
                    .HasMaxLength(255);

                entity.Property(e => e.IssRetido).HasColumnType("decimal");

                entity.Property(e => e.LoteNf)
                    .HasColumnName("lote_nf")
                    .HasColumnType("decimal");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(255);

                entity.Property(e => e.NatopNf)
                    .HasColumnName("natop_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.Nomecliente)
                    .HasColumnName("NOMECLIENTE")
                    .HasMaxLength(255);

                entity.Property(e => e.Nomeos)
                    .HasColumnName("NOMEOS")
                    .HasMaxLength(255);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(255);

                entity.Property(e => e.NumDoc)
                    .HasColumnName("NUM DOC")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Numcliente)
                    .HasColumnName("NUMCLIENTE")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Numos)
                    .HasColumnName("NUMOS")
                    .HasMaxLength(255);

                entity.Property(e => e.OpsnNf)
                    .HasColumnName("opsn_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.OutrasRetencoes)
                    .HasComputedColumnSql("round(([VALORCERT]*[OutrasRetencoesPercent])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OutrasRetencoesPercent)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegimeEspecialTributacao).HasMaxLength(255);

                entity.Property(e => e.Retenção)
                    .HasColumnName("RETENÇÃO")
                    .HasColumnType("decimal");

                entity.Property(e => e.Retenções)
                    .HasColumnName("RETENÇÕES")
                    .HasComputedColumnSql("round(([VALORCERT]*[RETENÇÃO])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeriNf)
                    .HasColumnName("seri_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.Servico).HasMaxLength(255);

                entity.Property(e => e.StatusRps)
                    .HasColumnName("status_rps")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefone)
                    .HasColumnName("TELEFONE")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO DOC")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoNf)
                    .HasColumnName("tipo_nf")
                    .HasMaxLength(255);

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasMaxLength(255);

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(255);

                entity.Property(e => e.ValorCofins)
                    .HasComputedColumnSql("round(([VALORCERT]*[ValorCofinsPercent])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorCofinsPercent)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValorCsll)
                    .HasComputedColumnSql("round(([VALORCERT]*[ValorCsllPercent])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorCsllPercent)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValorDeducoes)
                    .HasComputedColumnSql("round(([VALORCERT]*[ValorDeducoesPercent])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorDeducoesPercent)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValorDescontoIncPercent)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValorInss)
                    .HasComputedColumnSql("round(([VALORCERT]*[ValorInssPercent])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorInssPercent)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValorIr)
                    .HasComputedColumnSql("round(([VALORCERT]*[ValorIrPercent])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorIrPercent)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValorIss)
                    .HasComputedColumnSql("round((([VALORCERT]-(([VALORCERT]*[ValorDeducoesPercent])/CONVERT([float],(100))+([VALORCERT]*[ValorDescontoIncPercent])/CONVERT([float],(100))))*[Aliquota])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorIssRetido)
                    .HasComputedColumnSql("round(case when [IssRetido]=(1) then (([VALORCERT]-(([VALORCERT]*[ValorDeducoesPercent])/CONVERT([float],(100))+([VALORCERT]*[ValorDescontoIncPercent])/CONVERT([float],(100))))*[Aliquota])/CONVERT([float],(100)) else (0) end,(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorLiquido)
                    .HasColumnName("ValorLIquido")
                    .HasComputedColumnSql("round([VALORCERT]-((((((((([VALORCERT]*[ValorPisPercent])/CONVERT([float],(100))+([VALORCERT]*[ValorCofinsPercent])/CONVERT([float],(100)))+([VALORCERT]*[ValorInssPercent])/CONVERT([float],(100)))+([VALORCERT]*[ValorIrPercent])/CONVERT([float],(100)))+([VALORCERT]*[ValorCsllPercent])/CONVERT([float],(100)))+([VALORCERT]*[DescontoCondicionadoPercent])/CONVERT([float],(100)))+([VALORCERT]*[ValorDescontoIncPercent])/CONVERT([float],(100)))+([VALORCERT]*[OutrasRetencoesPercent])/CONVERT([float],(100)))+case when [IssRetido]=(1) then (([VALORCERT]-(([VALORCERT]*[ValorDeducoesPercent])/CONVERT([float],(100))+([VALORCERT]*[ValorDescontoIncPercent])/CONVERT([float],(100))))*[Aliquota])/CONVERT([float],(100)) else (0) end),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorPis)
                    .HasComputedColumnSql("round(([VALORCERT]*[ValorPisPercent])/CONVERT([float],(100)),(2))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ValorPisPercent)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Valorcert)
                    .HasColumnName("VALORCERT")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p._60CertificacaoEquipamentos)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("60_CertificacaoEquipamentos${7F6259EC-2583-4BE0-9D24-86084DCBEC16}");
            });

            modelBuilder.Entity<_60CertificacaoEquipamentosId>(entity =>
            {
                entity.ToTable("60_CertificacaoEquipamentosID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cert)
                    .HasColumnName("CERT")
                    .HasMaxLength(255);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Procesada)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");
            });

            modelBuilder.Entity<_60ProdutosGns>(entity =>
            {
                entity.ToTable("60_ProdutosGNS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Historico)
                    .HasColumnName("HISTORICO")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoDeConta).HasColumnName("TIPO DE CONTA");
            });

            modelBuilder.Entity<ClientesWeb>(entity =>
            {
                entity.ToTable("ClientesWeb");

                entity.HasKey(e => e.Id)
                .HasName("PK_ClientesWeb");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NomeCompleto)
                .HasColumnName("NOMECOMPLETO")
                .HasMaxLength(255);

                entity.Property(e => e.Senha)
                .HasColumnName("SENHA")
                .HasMaxLength(255);

                entity.Property(e => e.StatusLogin)
                .HasColumnName("STATUSLOGIN")
                .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(255);
            });

        }
    }
}