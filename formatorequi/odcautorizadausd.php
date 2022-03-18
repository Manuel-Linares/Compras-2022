<?php require_once('../Connections/comprashgo.php'); ?>
<link rel="shortcut icon" href="favicon.ico">
<?php
$colname_ODC = "1";
if (isset($_GET['id'])) {
  $colname_ODC = (get_magic_quotes_gpc()) ? $_GET['id'] : addslashes($_GET['id']);
}
mysql_select_db($database_comprashgo, $comprashgo);
$query_ODC = sprintf("SELECT * FROM ODC_FORMATO WHERE id = %s", $colname_ODC);
$ODC = mysql_query($query_ODC, $comprashgo) or die(mysql_error());
$row_ODC = mysql_fetch_assoc($ODC);
$totalRows_ODC = mysql_num_rows($ODC);

$colname_ODCDETA = "1";
if (isset($_GET['id'])) {
  $colname_ODCDETA = (get_magic_quotes_gpc()) ? $_GET['id'] : addslashes($_GET['id']);
}
mysql_select_db($database_comprashgo, $comprashgo);
$query_ODCDETA = sprintf("SELECT * FROM odecdetalle WHERE odcid = %s", $colname_ODCDETA);
$ODCDETA = mysql_query($query_ODCDETA, $comprashgo) or die(mysql_error());
$row_ODCDETA = mysql_fetch_assoc($ODCDETA);
$totalRows_ODCDETA = mysql_num_rows($ODCDETA);
?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<title>Orden de Compra - AUTORIZADA</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<style type="text/css">
<!--
.Estilo1 {
	font-family: Calibri;
	font-size: 36px;
	font-weight: bold;
}
.Estilo2 {font-size: 24px}
.Estilo3 {font-family: Calibri}
.Estilo4 {
	font-size: 9px;
	font-weight: bold;
}
.Estilo5 {
	font-family: Calibri;
	font-size: 9px;
	font-weight: bold;
}
.Estilo7 {font-family: Calibri; font-size: 10px; }
.Estilo15 {font-size: 14px}
.Estilo16 {font-size: 14px; font-family: Calibri; }
.Estilo18 {
	font-size: 18px;
	font-weight: bold;
}
.Estilo20 {font-size: 12px}
.Estilo22 {font-size: 16px}
.Estilo23 {font-size: 16}
.Estilo26 {font-family: Calibri; font-weight: bold; font-size: 12px; }
.style10 {font-size: 12px; font-weight: bold; }
.Estilo27 {font-family: Calibri; font-size: 12px; }
.Estilo29 {font-family: Calibri; font-size: 10px; font-weight: bold; }
.Estilo30 {font-size: 10px}
.Estilo33 {font-size: 10}
-->
</style>
</head>

<body>
<table width="792" border="0" align="center">
  <tr>
    <td height="105"><div align="center" class="Estilo1">
      <div align="left"><img src="img.png" width="78" height="93"><br>
      </div>
    </div></td>
    <td colspan="3"><div align="center"><span class="Estilo1">ORDEN DE COMPRA<br>
        <span class="Estilo2">PURCHASE ORDER</span></span></div></td>
  </tr>
  <tr>
    <td width="152" rowspan="3" valign="top"><div align="right" class="Estilo5">FACTURAR A: </div></td>
    <td width="340" rowspan="3"><p class="Estilo3 Estilo4">FUNDACION TELETON M&Eacute;XICO, A.C.<br>
      Av. Fomento Minero # 105<br>
      Col. Venta Prieta<br>
      42080 Pachuca de Soto, Hidalgo<br>
      RFC (TAXID) FTM 981104540<br>
    Tel. +52 ()     </p>    </td>
    <td height="18" colspan="2" valign="top" bordercolor="#000000"><div align="center"><strong></strong></div></td>
  </tr>
  <tr>
    <td align="center" valign="middle" bordercolor="#000000"><div align="center" class="Estilo3 Estilo18 Estilo20">
      <div align="right"><strong><span class="Estilo3">NUMERO / NUMBER : </span></strong></div>
    </div></td>
    <td align="center" valign="middle" bordercolor="#000000"><div align="center"><span class="Estilo3 Estilo18 Estilo23"><?php echo $row_ODC['id']; ?></span></div></td>
  </tr>
  <tr>
    <td width="161" align="center" valign="middle" bordercolor="#000000"><div align="right"><strong><span class="Estilo7"><span class="Estilo20">FECHA:</span> </span></strong></div></td>
    <td width="121" align="center" valign="middle" bordercolor="#000000"><div align="center"><strong><span class="Estilo7"><span class="Estilo22"><?php echo $row_ODC['FCREACION']; ?></span></span></strong></div></td>
  </tr>
</table>
<table width="792" border="1" align="center" bordercolor="#000000">
  <tr>
    <td width="47%"><span class="Estilo5">PROVEEDOR: / SUPPLIER :</span></td>
    <td width="53%"><span class="Estilo5">CONSIGNAR A: /CONSIGN TO:</span></td>
  </tr>
  <tr>
    <td><p class="Estilo7"><?php echo $row_ODC['proveedor']; ?><br>
      <?php echo $row_ODC['provdomi']; ?><br>
      <?php echo $row_ODC['provrfc']; ?><br>
      <?php echo $row_ODC['provtel']; ?></p>    </td>
    <td align="center" valign="middle"><p align="center"><span class="Estilo7"><?php echo $row_ODC['consignara']; ?></span><br>
        <span class="Estilo7">Av. Fomento Minero # 105<br>
    Col. Venta Prieta<br>
    CP 42080, Pachuca de Soto
        </span> </p>    </td>
  </tr>
  <tr>
    <td><span class="Estilo5">CONTACTO: / CONTACT:</span></td>
    <td><span class="Estilo5">ENTREGAR A: / DELIVER TO:</span></td>
  </tr>
  <tr>
    <td><p class="Estilo7"><?php echo $row_ODC['contacto']; ?><br>
        <?php echo $row_ODC['contacmail']; ?> </p>    </td>
    <td align="center" valign="middle"><div align="center"><span class="Estilo7"><?php echo $row_ODC['consignara']; ?><br>
    <?php echo $row_ODC['entregara']; ?></span></div></td>
  </tr>
  <tr>
    <td><span class="Estilo5">FECHA DE EMBARQUE: / SHIPPING DATE:</span></td>
    <td><span class="Estilo5">CENTRO DE COSTOS: / COST CENTER:</span></td>
  </tr>
  <tr align="center" valign="middle">
    <td><p class="Estilo7"><?php echo $row_ODC['FEMBARQUE']; ?></p>    </td>
    <td><p align="center" class="Estilo7"><strong><?php echo $row_ODC['area']; ?></strong><br>
      <?php echo $row_ODC['centrocostos']; ?></p>    </td>
  </tr>
  <tr align="center" valign="middle">
    <td><span class="Estilo5">CONDICIONES DE EMBARQUE: /SHIPPING TERMS:</span></td>
    <td><span class="Estilo5">COMIT&Eacute; DE COMPRAS</span></td>
  </tr>
  <tr align="center" valign="middle">
    <td><p class="Estilo7"><?php echo $row_ODC['condiembarque']; ?></p>    </td>
    <td><div align="center">
      <p class="Estilo7"><?php echo $row_ODC['COMITE']; ?></p>
    </div></td>
  </tr>
  <tr>
    <td colspan="2"><span class="Estilo5">OBSERVACIONES: / REMARKS:</span></td>
  </tr>
  <tr>
    <td colspan="2"><span class="Estilo7"><?php echo $row_ODC['observaciones']; ?><br>
    </span></td>
  </tr>
</table>
<br>
<table width="792" border="1" align="center" bordercolor="#000000">
  <tr>
    <td><span class="Estilo26">PARTIDA</span></td>
    <td><span class="Estilo26">REQUISICION</span></td>
    <td><span class="Estilo26">CODIGO</span></td>
    <td><span class="Estilo26">DESCRIPCION</span></td>
    <td><div align="center"><span class="Estilo26">UNIDAD</span></div></td>
    <td><div align="center"><span class="Estilo26">CANTIDAD</span></div></td>
    <td><div align="center"><span class="Estilo26">PRECIO UNITARIO</span></div></td>
    <td><div align="center"><span class="Estilo26">TOTAL</span></div></td>
  </tr>
   <?php $orden=0;  ?>
   <?php $sub=0;  ?>
  <?php do { ?>
  
  <tr>
   <?php $orden++;?>
    <td><div align="center"><span class="Estilo7
	"><?php echo $orden; ?></span></div></td>
    <td class="Estilo7"><?php echo $row_ODCDETA['requifolio']; ?></td>
    <td><div align="center"><span class="Estilo7"><?php echo $row_ODCDETA['codigo']; ?></span></div></td>
    <td><span class="Estilo7"><?php echo $row_ODCDETA['descripcion']; ?></span></td>
    <td><div align="center"><span class="Estilo7"><?php echo $row_ODCDETA['udemedida']; ?></span></div></td>
    <td><div align="center"><span class="Estilo7"><?php echo $row_ODCDETA['cantidad']; ?></span></div></td>
    <td><div align="center"><span class="Estilo7"><?php echo $row_ODCDETA['punitario']; ?></span></div></td>
    <td><div align="center"><span class="Estilo7"><?php echo number_format($row_ODCDETA['cantidad']*$row_ODCDETA['punitario'],2); ?></span></div></td>
  </tr>
  <?php $sub+=$row_ODCDETA['cantidad']*$row_ODCDETA['punitario']; ?>
  <?php } while ($row_ODCDETA = mysql_fetch_assoc($ODCDETA)); ?>
</table>
<br>
<table width="792" border="1" align="center" bordercolor="#000000">
  <tr>
    <td width="162" rowspan="3" align="center" valign="top"><span class="Estilo29">FECHA, NOMBRE Y FIRMA DE QUIEN RECIBE ORDEN DE COMPRA:</span></td>
    <td width="70" rowspan="2"><div align="center" class="Estilo30"><strong><span class="Estilo3">Plazo de Prueba o Garant&iacute;a</span></strong></div></td>
    <td width="53" rowspan="2"><div align="center" class="Estilo30"><strong><span class="Estilo3">Forma de Pago</span></strong></div></td>
    <td width="55" rowspan="3"><div align="center"><strong><span class="Estilo27">Fianzas</span></strong></div></td>
    <td width="98"><span class="Estilo26">Anticipo:</span></td>
    <td width="59">&nbsp;</td>
    <td width="97" class="Estilo27"><div align="right" class="Estilo20"><strong><span class="Estilo3">SUBTOTAL </span></strong></div></td>
    <td width="146" class="Estilo27"><div align="center" class="Estilo22"><strong>$ <?php echo number_format($sub,2); ?> USD </strong></div></td>
  </tr>
  <tr>
    <td height="23"><span class="Estilo26">Cumplimiento:</span></td>
    <td>&nbsp;</td>
    <td class="Estilo27"><div align="right" class="Estilo20"><strong><span class="Estilo3">IVA /TAX </span></strong></div></td>
    <td class="Estilo27"><div align="center" class="Estilo20"><strong><span class="Estilo3">$ <?php echo round(($sub*.16)*100)/100; ?> USD </span></strong></div></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td><span class="Estilo26">Buena calidad y vicios ocultos</span></td>
    <td>&nbsp;</td>
    <td class="Estilo27"><div align="right" class="Estilo20"><strong><span class="Estilo3">TOTAL</span></strong></div></td>
    <td class="Estilo27"><div align="center" class="Estilo20"><strong><span class="Estilo22">$ <?php echo number_format(round(($sub*1.16)*100)/100,2); ?> USD </span></strong></div></td>
  </tr>
</table>
<br>
<table width="792" border="0" align="center">
  <tr align="center" valign="baseline">
    <td width="225" height="36"><div align="center"><img src="compras.jpg" width="103" height="62"></div></td>
    <td width="34">&nbsp;</td>
    <td width="225"><div align="center"><img src="cs.jpg" width="103" height="62"></div></td>
    <td width="34">&nbsp;</td>
    <td width="225"><div align="center"></div></td>
  </tr>
  <tr align="center" valign="baseline">
    <td><div align="center"><span class="Estilo27">____________________________<br>
      Jonathan Mej&iacute;a Cer&oacute;n<br>
      Auxiliar de Compras<br>
      <br>
    </span></div></td>
    <td><div align="center"></div></td>
<td><p align="center" class="Estilo27">___________________________<br>
      Cristina Su&aacute;rez Hern&aacute;ndez<br>
      Subdirecci&oacute;n de RRMM      <br>
    <strong>Autorizaci&oacute;n:</strong> <?php echo $row_ODC['AUTRM']; ?> </p>   </td>
    <td><div align="center"></div></td>
    <td><p align="center" class="Estilo27"><br>
    </p>    </td>
  </tr>
  <tr align="center" valign="baseline">
    <td height="70">&nbsp;</td>
    <td height="70">&nbsp;</td>
    <td height="70">&nbsp;</td>
    <td height="70">&nbsp;</td>
    <td height="70">&nbsp;</td>
  </tr>
  <tr align="center" valign="baseline">
    <td height="36">&nbsp;</td>
    <td>&nbsp;</td>
    <td height="36"><span class="Estilo27">___________________________<br>
    Blanca Reyes Avi&ntilde;a <br>
    Subdirecci&oacute;n de Administraci&oacute;n </span></td>
    <td>&nbsp;</td>
    <td><span class="Estilo27">___________________________<br>
    Agust&iacute;n Lagunas Oseguera <br>
    Direcci&oacute;n General</span></td>
  </tr>
  <tr align="center" valign="baseline">
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</body>
</html>
<?php
mysql_free_result($ODC);

mysql_free_result($ODCDETA);
?>
