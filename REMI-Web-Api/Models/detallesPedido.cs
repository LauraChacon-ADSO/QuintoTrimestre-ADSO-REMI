using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace REMI_Web_Api.Models;

[PrimaryKey("codigoPedido", "codigoProducto")]
public partial class detallesPedido
{
    [Key]
    public int codigoPedido { get; set; }

    [Key]
    public int codigoProducto { get; set; }

    public double cantidadProducto { get; set; }

    public double valorProducto { get; set; }

    public double totalPagoProducto { get; set; }

    [ForeignKey("codigoPedido")]
    [InverseProperty("detalles")]
    public virtual pedido codigoPedidoNavigation { get; set; } = null!;

    [ForeignKey("codigoProducto")]
    [InverseProperty("detalles")]
    public virtual producto codigoProductoNavigation { get; set; } = null!;
}
