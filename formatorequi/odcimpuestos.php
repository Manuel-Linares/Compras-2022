<?php require_once('../Connections/comprashgo.php'); ?>

<link rel="shortcut icon" href="favicon.ico">

<?php

mysqli_select_db( $comprashgo, $database_comprashgo);

$query_ODC_AUT = "SELECT id FROM ODC_AUTORIZADAS WHERE estatus = 'Autorizada DO' ORDER BY id DESC";

$ODC_AUT = mysqli_query($comprashgo, $query_ODC_AUT) or die(mysqli_error());

$row_ODC_AUT = mysqli_fetch_assoc($ODC_AUT);

$totalRows_ODC_AUT = mysqli_num_rows($ODC_AUT);

?>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>

<head>

<title>Documento sin t&iacute;tulo</title>

<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">

<style type="text/css">

<!--

body,td,th {

	font-family: Calibri;

	font-size: 12px;

}

-->

</style></head>



<body>

<form action="https://controlsit.mx/comprashgo/formatorequi/odcautorizada_impuestos.php?<?php echo $_GET['tipo']; ?>=<?php echo $_GET['tipo']; ?>&<?php echo $_GET['id']; ?>=<?php echo $_GET['id']; ?>&<?php echo $_GET['monto']; ?>=<?php echo $_GET['monto']; ?>&<?php echo $_GET['iva']; ?>=<?php echo $_GET['iva']; ?>" target="_blank">

  <p>Orden de Compra Autorizada :<br>

    <select name="id">

      <?php

do {  

?>

      <option value="<?php echo $row_ODC_AUT['id']?>"><?php echo $row_ODC_AUT['id']?></option>

      <?php

} while ($row_ODC_AUT = mysqli_fetch_assoc($ODC_AUT));

  $rows = mysqli_num_rows($ODC_AUT);

  if($rows > 0) {

      mysqli_data_seek($ODC_AUT, 0);

	  $row_ODC_AUT = mysqli_fetch_assoc($ODC_AUT);

  }

?>

    </select>

  </p>

  <p>Selecciona el tipo de impuesto :<br>

    <select name="tipo">

      <option value="IEPS">IEPS</option>

      <option value="Impuesto Sobre Hospedaje">Impuesto Sobre Hospedaje</option>

    </select>

  </p>

  <p>Monto del Impuesto :<br>

    <input name="monto" type="text" size="15">

</p>

  <p>IVA :<br>

    <input name="iva" type="text" size="15">

</p>

  <p>

    <input type="submit" value="Genera ODC / Impuestos">

</p>

</form>

</body>

</html>

<?php

mysqli_free_result($ODC_AUT);

?>

