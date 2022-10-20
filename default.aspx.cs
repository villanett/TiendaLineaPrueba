using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _default : System.Web.UI.Page
{
    private const string usuariocliente = "tiendavirtual";
    private const string passwordcliente = "LEhMvqxvrTvfvvPv4vbrrEwvKOv4ACCM7Ov18nE4nequ3o2vVc1acbvvHwxr43vjM14Kfkeg3fJnkBDSvv";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            tiendavirtual.TiendaVirtualSoapClient serv = new tiendavirtual.TiendaVirtualSoapClient();
            string sresultado = serv.ObtenerCategorias(usuariocliente, passwordcliente);
            lblResultado1.Text = Server.HtmlEncode(sresultado);
        }
        catch (Exception exc)
        {
            lblError.Text = "ERROR: " + exc.ToString();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            tiendavirtual.TiendaVirtualSoapClient serv = new tiendavirtual.TiendaVirtualSoapClient();
            string sresultado = serv.ObtenerEtiquetas(usuariocliente, passwordcliente);
            lblResultado2.Text = Server.HtmlEncode(sresultado);
        }
        catch (Exception exc)
        {
            lblError.Text = "ERROR: " + exc.ToString();
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            string filtrocategoria = "";
            string filtroetiqueta = "'Mujer'";
            tiendavirtual.TiendaVirtualSoapClient serv = new tiendavirtual.TiendaVirtualSoapClient();
            string sresultado = serv.ObtenerArticulosMultiple(filtrocategoria, filtroetiqueta, "", "", "", "", "", "", 5, 0, usuariocliente, passwordcliente);
            //obtener cantidad
            string scantidad = serv.ObtenerArticulosCantidad(filtrocategoria, filtroetiqueta, "", "", "", "", "", usuariocliente, passwordcliente);
            lblResultado3.Text = Server.HtmlEncode(sresultado) + " CANTIDAD= " + scantidad;
        }
        catch (Exception exc)
        {
            lblError.Text = "ERROR: " + exc.ToString();
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            string fecha = "2017-07-31";
            tiendavirtual.TiendaVirtualSoapClient serv = new tiendavirtual.TiendaVirtualSoapClient();
            string sresultado = serv.ObtenerPromocionesMultiple(fecha, "", -1, -1, usuariocliente, passwordcliente);
            lblResultado4.Text = Server.HtmlEncode(sresultado);
        }
        catch (Exception exc)
        {
            lblError.Text = "ERROR: " + exc.ToString();
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {
            tiendavirtual.TiendaVirtualSoapClient serv = new tiendavirtual.TiendaVirtualSoapClient();
            string sresultado = serv.ObtenerArticulo(txb5.Text, usuariocliente, passwordcliente);
            lblResultado51.Text = Server.HtmlEncode(sresultado);
            imgResultado52.Visible = false;
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(sresultado);
            System.Xml.XmlNodeList nodos = xmldoc.SelectNodes("//Articulo");
            if (nodos != null && nodos.Count > 0)
            {
                string url = (nodos[0] as System.Xml.XmlElement).GetAttribute("imagen");
                if (url != "")
                {
                    imgResultado52.ImageUrl = url;
                    imgResultado52.Visible = true;
                }
            }
        }
        catch (Exception exc)
        {
            lblError.Text = "ERROR: " + exc.ToString();
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        try
        {
            int tipopago = Convert.ToInt32(ddl6.SelectedValue);
            string xmlarticulos = "<RAIZ><Articulo codigo=\"A101\" cantidad=\"1\" precio=\"348\" iva=\"16\" ieps=\"0\" /><Articulo codigo=\"A102\" cantidad=\"2\" precio=\"600\" iva=\"0\" ieps=\"0\" /><Articulo codigo=\"A103\" cantidad=\"3\" precio=\"696\" iva=\"16\" ieps=\"0\" /><Articulo codigo=\"B101\" cantidad=\"3.3\" precio=\"1740.05\" iva=\"16\" ieps=\"0.05\" /></RAIZ>";
            tiendavirtual.TiendaVirtualSoapClient serv = new tiendavirtual.TiendaVirtualSoapClient();
            lblResultado6.Text = serv.AgregarCotizacionMultiple(tipopago, xmlarticulos, "Nombre", "Apellidos", "email@email.com", "telefono",
                "calle", "numero", "colonia", "cp", "pais", "estado", "municipio", "comentario del pedido", usuariocliente, passwordcliente, "Folio en la Tienda");
        }
        catch (Exception exc)
        {
            lblError.Text = "ERROR: " + exc.ToString();
        }
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        try
        {
            string folio = "0101004000000005420170914000000765696691";
            string rfc = "AAA010101AAA";
            tiendavirtual.TiendaVirtualSoapClient serv = new tiendavirtual.TiendaVirtualSoapClient();
            string sresultado = serv.SolicitarFacturacion(folio, rfc, usuariocliente, passwordcliente);
            lblResultado7.Text = Server.HtmlEncode(sresultado);
        }
        catch (Exception exc)
        {
            lblError.Text = "ERROR: " + exc.ToString();
        }
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        try
        {
            string folio = "0101004000000002220170801000000937822158";
            string rfc = "XEXX010101000";
            tiendavirtual.TiendaVirtualSoapClient serv = new tiendavirtual.TiendaVirtualSoapClient();
            string sresultado = serv.FacturarFolio(folio, rfc, "Prueba Genérico", "calle", "numexterior", "numinterior", "colonia", "pais", "estado", "municipio", "cp", "email", usuariocliente, passwordcliente);
            if (sresultado.Contains("|"))
            {
                string[] arrresultado = sresultado.Split("|".ToCharArray());
                hlk8xml.Text = arrresultado[0];
                hlk8xml.NavigateUrl = arrresultado[0];
                hlk8pdf.Text = arrresultado[1];
                hlk8pdf.NavigateUrl = arrresultado[1];
            }
        }
        catch (Exception exc)
        {
            lblError.Text = "ERROR: " + exc.ToString();
        }
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        try
        {
            tiendavirtual.TiendaVirtualSoapClient serv = new tiendavirtual.TiendaVirtualSoapClient();
            int tipo = Convert.ToInt32(ddlTipo.SelectedValue);
            string linea = ""; string dimension = ""; string division = ""; string grupo = ""; string subgrupo = "";
            switch (tipo)
            {
                case 1:
                    linea = "Accesorios";
                    break;
                case 2:
                    linea = "Accesorios";
                    dimension = "Nacional";
                    break;
                case 3:
                    linea = "Accesorios";
                    dimension = "Nacional";
                    division = "Español";
                    break;
                case 4:
                    linea = "Accesorios";
                    dimension = "Nacional";
                    division = "Español";
                    grupo = "mexicano";
                    break;
                case 5:
                    linea = "Accesorios";
                    dimension = "Nacional";
                    division = "Español";
                    grupo = "mexicano";
                    subgrupo = "24";
                    break;
            }
            string sresultado = "";
            if (tipo <= 4)
                sresultado = serv.ObtenerGrupos(tipo, linea, dimension, division, grupo, subgrupo, usuariocliente, passwordcliente);
            if (tipo == 5)
                sresultado = serv.ObtenerArticulosMultiple(linea, "", "", dimension, division, grupo, subgrupo, "", 50, 0, usuariocliente, passwordcliente);
            lblResultado9.Text = Server.HtmlEncode(sresultado);
        }
        catch (Exception exc)
        {
            lblError.Text = "ERROR: " + exc.ToString();
        }
    }

}