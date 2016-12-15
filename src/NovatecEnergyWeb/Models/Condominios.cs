using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class Condominios
    {
        public int IdCondominio { get; set; }
        public string Nombre { get; set; }
        public int? Numerodeviviendas { get; set; }
        public string Numviviendasreal { get; set; }
        public double? Porcentajeocupacion { get; set; }
        public string Niveldevida { get; set; }
        public string Nomimagen { get; set; }
        public byte[] Imagenbits { get; set; }
        public DateTime? FechaFoto1 { get; set; }
        public string Nomimagen2 { get; set; }
        public byte[] Imagenbits2 { get; set; }
        public DateTime? FechaFoto2 { get; set; }
        public DateTime? FechaAlta { get; set; }
        public double? Longitud { get; set; }
        public double? Latitud { get; set; }
        public string Direccion { get; set; }
        public string ZipCode { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public bool? ContactoRealizado { get; set; }
        public string PersonaDeContacto { get; set; }
        public string CargoContacto { get; set; }
        public bool? MuestraInteresContacto { get; set; }
        public string ObservacionesInteresContacto { get; set; }
        public string Observaciones { get; set; }
        public int? CodTecnico { get; set; }
        public double? MetrosAredMasProxima { get; set; }
        public string TipoCombustibleActual { get; set; }
        public bool? CalentadorExistente { get; set; }
        public string TipoNegocio { get; set; }
        public double? MetrosRedInterna { get; set; }
        public string PresionRed { get; set; }
        public double? DiametroRedInterna { get; set; }
        public int? NumeroRamales { get; set; }
        public bool? InstalacionInternaExistente { get; set; }
        public double? MetrosMedioInterna { get; set; }
        public byte[] Imagenbitsreducida { get; set; }
        public string Area { get; set; }
        public string Bairro { get; set; }
        public string TipoConstrucao { get; set; }
        public string Estatus { get; set; }
        public double? PorcentajeCaptacaoPrevisto { get; set; }
        public double? D2previsto { get; set; }
        public string Anotaciones { get; set; }
        public double? MetrosRedExterna { get; set; }
        public string DataEntrega { get; set; }
        public double? InvComercial { get; set; }
        public double? InvIrc { get; set; }
        public double? InvRedInterna { get; set; }
        public double? InvRedExterna { get; set; }
        public DateTime? Timestamp { get; set; }
        public string InstalacaoGasInterna { get; set; }
        public string Plexistente { get; set; }
        public string AquecedorExistente { get; set; }
        public string ObservacionesInteres { get; set; }
        public string TelefonoContacto { get; set; }
        public string EmailContacto { get; set; }
        public string PercepcaoProducto { get; set; }
        public string GostariaReceberProposta { get; set; }
        public double? ValorPrimaMedia { get; set; }
        public double? ValorIrcmedio { get; set; }
        public double? RinternaMedio { get; set; }
        public double? RexternaMedio { get; set; }
    }
}
