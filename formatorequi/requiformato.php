<?php require_once('../Connections/comprashgo.php'); ?>

<?php require_once('../Connections/comprashgo.php'); ?>

<link rel="shortcut icon" href="favicon.ico">

<?php

$colname_Recordset1 = "1";

if (isset($_GET['folio'])) {

  $colname_Recordset1 = (get_magic_quotes_gpc()) ? $_GET['folio'] : addslashes($_GET['folio']);

}

mysqli_select_db($comprashgo, $database_comprashgo );

$query_Recordset1 = sprintf("SELECT * FROM REQUI_FORMATO WHERE FOLIO = %s", $colname_Recordset1);

$Recordset1 = mysqli_query( $comprashgo, $query_Recordset1) or die(mysqli_error());

$row_Recordset1 = mysqli_fetch_assoc($Recordset1);

$totalRows_Recordset1 = mysqli_num_rows($Recordset1);



$maxRows_DETALLE = 10;

$pageNum_DETALLE = 0;

if (isset($_GET['pageNum_DETALLE'])) {

  $pageNum_DETALLE = $_GET['pageNum_DETALLE'];

}

$startRow_DETALLE = $pageNum_DETALLE * $maxRows_DETALLE;



$colname_DETALLE = "1";

if (isset($_GET['folio'])) {

  $colname_DETALLE = (get_magic_quotes_gpc()) ? $_GET['folio'] : addslashes($_GET['folio']);

}

mysqli_select_db($comprashgo, $database_comprashgo);

$query_DETALLE = sprintf("SELECT * FROM detalle WHERE foliorequi = %s ORDER BY folio ASC", $colname_DETALLE);

$query_limit_DETALLE = sprintf("%s LIMIT %d, %d", $query_DETALLE, $startRow_DETALLE, $maxRows_DETALLE);

$DETALLE = mysqli_query( $comprashgo, $query_limit_DETALLE) or die(mysqli_error());

$row_DETALLE = mysqli_fetch_assoc($DETALLE);



if (isset($_GET['totalRows_DETALLE'])) {

  $totalRows_DETALLE = $_GET['totalRows_DETALLE'];

} else {

  $all_DETALLE = mysqli_query($comprashgo,$query_DETALLE);

  $totalRows_DETALLE = mysqli_num_rows($all_DETALLE);

}

$totalPages_DETALLE = ceil($totalRows_DETALLE/$maxRows_DETALLE)-1;

?>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>

<head>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8">

<title>REQUISICIÓN DE MATERIAL O SERVICIO Anexo 1 SC - RM - 002</title>

	<link rel="icon" type="image/png" href="../favicon.ico" />

<style type="text/css">

<!--

.xl997180 {padding:0px;

	mso-ignore:padding;

	color:windowtext;

	font-size:14.0pt;

	font-weight:700;

	font-style:normal;

	text-decoration:none;

	font-family:Arial, sans-serif;

	mso-font-charset:0;

	mso-number-format:General;

	text-align:center;

	vertical-align:bottom;

	mso-background-source:auto;

	mso-pattern:auto;

	white-space:nowrap;}

.style1 {

	font-family: Verdana, Arial, Helvetica, sans-serif;

	font-weight: bold;

}

.style2 {font-family: Verdana, Arial, Helvetica, sans-serif}

.xl9971801 {padding:0px;

	mso-ignore:padding;

	color:windowtext;

	font-size:14.0pt;

	font-weight:700;

	font-style:normal;

	text-decoration:none;

	font-family:Arial, sans-serif;

	mso-font-charset:0;

	mso-number-format:General;

	text-align:center;

	vertical-align:bottom;

	mso-background-source:auto;

	mso-pattern:auto;

	white-space:nowrap;}

.xl99718011 {padding:0px;

	mso-ignore:padding;

	color:windowtext;

	font-size:14.0pt;

	font-weight:700;

	font-style:normal;

	text-decoration:none;

	font-family:Arial, sans-serif;

	mso-font-charset:0;

	mso-number-format:General;

	text-align:center;

	vertical-align:bottom;

	mso-background-source:auto;

	mso-pattern:auto;

	white-space:nowrap;}

.style4 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }

.style6 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }

.xl997180111 {padding:0px;

	mso-ignore:padding;

	color:windowtext;

	font-size:14.0pt;

	font-weight:700;

	font-style:normal;

	text-decoration:none;

	font-family:Arial, sans-serif;

	mso-font-charset:0;

	mso-number-format:General;

	text-align:center;

	vertical-align:bottom;

	mso-background-source:auto;

	mso-pattern:auto;

	white-space:nowrap;}

.style7 {font-size: 12px}

.style8 {font-size: smaller}

.style10 {font-size: 12px; font-weight: bold; }

.xl9971801111 {padding:0px;

	mso-ignore:padding;

	color:windowtext;

	font-size:14.0pt;

	font-weight:700;

	font-style:normal;

	text-decoration:none;

	font-family:Arial, sans-serif;

	mso-font-charset:0;

	mso-number-format:General;

	text-align:center;

	vertical-align:bottom;

	mso-background-source:auto;

	mso-pattern:auto;

	white-space:nowrap;}

.xl657180 {padding:0px;

	mso-ignore:padding;

	color:windowtext;

	font-size:10.0pt;

	font-weight:700;

	font-style:normal;

	text-decoration:none;

	font-family:Arial, sans-serif;

	mso-font-charset:0;

	mso-number-format:General;

	text-align:right;

	vertical-align:bottom;

	mso-background-source:auto;

	mso-pattern:auto;

	white-space:nowrap;}

-->

</style>

</head>



<body>

<table width="792" height="207"  border="0" align="center">

  <tr>

    <td rowspan="3"><div align="left"><img src="img.png" width="127" height="147"> </div>

      <div align="center"></div></td>

    <td height="96" colspan="3"><div align="center"><span class="xl9971801111">REQUISICI&Oacute;N DE MATERIAL O SERVICIO</span></div></td>

  </tr>

  <tr>

    <td rowspan="2" class="style4"><p>Av. Fomento Minero 105 <br>

        Colonia Venta Prieta<br>

    Pachuca de Soto Hidalgo </p>      <div align="center"></div></td>

    <td height="51" class="style1"><div align="right" class="style1">No. Requisici&oacute;n:</div></td>

    <td class="style1"><div align="right"><?php echo $row_Recordset1['FOLIO']; ?></div></td>

  </tr>

  <tr>

    <td height="51" class="style1"><div align="right" class="style1"><span class="style1">Fecha</span>:</div></td>

    <td class="style1"><div align="right"><?php echo $row_Recordset1['FC']; ?></div></td>

  </tr>

</table>

<table width="792" height="213"  border="0" align="center">

  <tr class="style4">

    <td width="138" height="31"><div align="left"><span class="style1">AREA SOLICITANTE:</span></div></td>

    <td width="5">&nbsp;</td>

    <td width="57">&nbsp;</td>

    <td width="193"><?php echo $row_Recordset1['AREA']; ?></td>

    <td width="19">&nbsp;</td>

    <td width="158"><div align="right"><span class="style1">FECHA AUTORIZACI&Oacute;N:</span></div></td>

    <td width="198"><div align="right"><?php echo $row_Recordset1['FA']; ?>

      </div>

    <div align="center"></div></td>

  </tr>

  <tr class="style4">

    <td height="27"><div align="left"><span class="style6">SOLICITANTE:</span></div></td>

    <td>&nbsp;</td>

    <td>&nbsp;</td>

    <td><span class="style2"><?php echo $row_Recordset1['SOLICITANTE']; ?></span></td>

    <td>&nbsp;</td>

    <td><div align="right" class="style1">FECHA ESTIMADA: </div></td>

    <td><div align="right"><?php echo $row_Recordset1['FE']; ?>

      </div>

    <div align="center"></div></td>

  </tr>

  <tr class="style4">

    <td height="26" class="style1"><div align="left">CUENTA:</div></td>

    <td colspan="4"><?php echo $row_Recordset1['CUENTA']; ?></td>

  <td><div align="right"></div></td>

    <td>&nbsp;</td>

  </tr>

  <tr>

    <td height="119" colspan="7"><table width="792" border="1" align="center">

      <tr class="style6">

        <td><div align="center"><span class="style10">PARTIDA</span></div></td>

        <td><div align="center">FOLIO</div></td>

        <td><div align="center"><span class="style10">CANTIDAD</span></div></td>

        <td><div align="left"><span class="style10">DESCRIPCION</span></div></td>

        <td><div align="center"><span class="style10">UNIDAD DE MEDICION </span></div></td>

      <td><div align="center"><span class="style10">COSTO<br>

  (EXCLUSIVO RM) </span></div></td>

      </tr>

	  <?php $orden=0;  ?>

      <?php do { ?>

      <tr class="style4">

	  <?php $orden++;?>

        <td><div align="center"><?php echo $orden; ?></div></td>

        <td><div align="center"><?php echo $row_DETALLE['folio']; ?></div></td>

        <td><div align="center"><?php echo $row_DETALLE['cantidad']; ?></div></td>

        <td><div align="justify"><?php echo $row_DETALLE['descripcion']; ?></div></td>

        <td><div align="center"><?php echo $row_DETALLE['medicion']; ?></div></td>

      <td>&nbsp;</td>

      </tr>

      <?php } while ($row_DETALLE = mysqli_fetch_assoc($DETALLE)); ?>

    </table></td>

  </tr>

</table>

  <table width="792" height="38"  border="0" align="center">

    <tr>

      <td height="34" colspan="3"><div align="center"></div>

      <div align="left"><span class="style6">PRESUPUESTO DISPONIBLE:</span><span class="style4"> </span></div></td>

      <td height="34"><span class="style4">$ <?php echo number_format($row_Recordset1['PPTO'],2); ?> pesos</span></td>

      <td height="34">&nbsp;</td>

      <td height="34" class="style6">COSTO APROXIMADO:</td>

      <td height="34" class="style4">$ <?php echo number_format($row_Recordset1['APROX'],2); ?> pesos </td>

    </tr>

  </table>

  

  <table width="792" height="177"  border="1" align="center" bordercolor="#000000">

    

	<tr>

    <td width="254" height="83" class="style6"><div align="justify">OBSERVACIONES SOLICITANTE</div></td>

    <td width="528" class="style4"><div align="center"><?php echo $row_Recordset1['OBSERVACIONES']; ?></div></td>

  </tr>

  <tr>

    <td height="88" class="style6"><div align="justify">OBSERVACIONES DIRECCION </div></td>

    <td class="style4"><?php echo $row_Recordset1['OBSERVACIONES DIRECCION']; ?>

        <div align="justify"></div>

    <div align="center"></div></td>

  </tr>

</table>

  <table width="792" height="114"  border="0" align="center">

  <tr valign="bottom">

    <td width="246" height="66" class="style1"><div align="center"></div></td>

    <td width="27" class="style1">&nbsp;</td>

    <td width="246" class="style1"><div align="center">

      <?php $direccion=""; ?>

      <?php $director=""; ?>

      <?php $dir=""; ?>

      <?php

			

		$direccion	=	$row_Recordset1['AREA']  ;

		

		if ($direccion=="") {

		$firma = "blank.png";

		$director = "Sin definir";

		$dir = "Sin definir";

		}

		if ($direccion == "Administración") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Talento y Cultura Organizacional") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Recursos Materiales") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Tecnologias de la Información") {

		$firma = "sin_firma.png";

		$director = "Carlos Pérez Godinez";

		$dir = "Coordinación de Tecnologias de la Información";

		}

		if ($direccion == "Recursos Materiales") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "ENFEI") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Atención al Público") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

				$dir = "Dirección General";

		}

		if ($direccion == "Reequipamiento") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Dirección General" ) {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Voluntariado") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Relaciones Públicas") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Bazar") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Dirección Médica") {

		$firma = "dm.png";

		$director = "Juan José Ramírez";

		$dir = "Dirección Médica";

		}

		if ($direccion == "Fondo de ayudas") {

		$firma = "dm.png";

		$director = "Juan José Ramírez";

		$dir = "Dirección Médica";

		}

		if ($direccion == "Club Amigos Teletón AS") {

		$firma = "dm.png";

		$director = "Juan José Ramírez";

		$dir = "Dirección Médica";

		}

		if ($direccion == "Cursos y seminarios") {

		$firma = "dm.png";

		$director = "Juan José Ramírez";

		$dir = "Dirección Médica";

		}

		if ($direccion == "Corporativo") {

		$firma = "compras.jpg";

		$director = "Jonathan Mejía Cerón";

		$dir = "Auxiliar de Compras";

		}

		if ($direccion == "Dale la mano a un amigo") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Teletón Amplificado") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "CAPSULA GOBERNADOR") {

		$firma = "dg.png";

		$director = "Agustín Lagunas Oseguera";

		$dir = "Dirección General";

		}

		if ($direccion == "Arturo Valdespino") {

		$firma = "dm.png";

		$director = "Juan José Ramírez";

		$dir = "Dirección Médica";

		}

		

		echo "<img src='$firma' width='100'height='66'/>";

		

		?>

    </div></td>

    <td width="27" class="style1">&nbsp;</td>

	

    <td width="246" colspan="2" class="style1"><div align="center"><img src="cs.jpg" width="144" height="79"></div></td>

  </tr>

  <tr valign="top">

    <td class="style1"><div align="center"><span class="style6">______________________<br>

      <?php echo $row_Recordset1['SOLICITANTE']; ?></span></div></td>

    <td class="style1">&nbsp;</td>

    <td class="style6"><div align="center">_______________________<br>

      <?php echo $director ; ?> <br>

      <?php echo $dir;?> </div></td>

    <td class="style1">&nbsp;</td>

    <td colspan="2" class="style6"><div align="center">____________________<br>

        Cristina Su&aacute;rez Hern&aacute;ndez <br>

        Subdirecci&oacute;n de RRMM </div></td>

  </tr>

</table>

<table width="792" border="0" align="center">

  <tr>

    <td><span class="style6"><span class="style2 style8">REQUISICI&Oacute;N NO <?php echo $_GET['folio']; ?> </span></span></td>

    <td><div align="right"><span class="style6">Anexo 1 SC - RM - 002</span></div></td>

  </tr>

</table>

</body>

</html>

<?php

mysqli_free_result($Recordset1);



mysqli_free_result($DETALLE);

?>

