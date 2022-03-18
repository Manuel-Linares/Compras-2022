<?php require_once('../Connections/comprashgo.php'); ?>
<?php
mysql_select_db($database_comprashgo, $comprashgo);
$query_ODC_AUT = "SELECT id FROM ODC_AUTORIZADAS WHERE estatus = ''Autorizada DO'' ORDER BY id DESC";
$ODC_AUT = mysql_query($query_ODC_AUT, $comprashgo) or die(mysql_error());
$row_ODC_AUT = mysql_fetch_assoc($ODC_AUT);
$totalRows_ODC_AUT = mysql_num_rows($ODC_AUT);
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
<form action="https://www.infosit.mx/comprashgo/formatorequi/odcautorizada_impuestos.php?<?php echo $_GET['tipo']; ?>=<?php echo $_GET['tipo']; ?>&<?php echo $_GET['id']; ?>=<?php echo $_GET['id']; ?>&<?php echo $_GET['monto']; ?>=<?php echo $_GET['monto']; ?>&<?php echo $_GET['iva']; ?>=<?php echo $_GET['iva']; ?>">
  <p>Orden de Compra Autorizada:<br>
    <select name="id">
      <?php
do {  
?>
      <option value="<?php echo $row_ODC_AUT['id']?>"><?php echo $row_ODC_AUT['id']?></option>
      <?php
} while ($row_ODC_AUT = mysql_fetch_assoc($ODC_AUT));
  $rows = mysql_num_rows($ODC_AUT);
  if($rows > 0) {
      mysql_data_seek($ODC_AUT, 0);
	  $row_ODC_AUT = mysql_fetch_assoc($ODC_AUT);
  }
?>
    </select>
  </p>
  <p>Selecciona el tipo de impuesto:<br>
    <select name="tipo">
      <option value="IEPS">IEPS</option>
      <option value="Impuesto Sobre Hospedaje">Impuesto Sobre Hospedaje</option>
    </select>
  </p>
  <p>Monto del Impuesto:<br>
    <input type="text" name="monto">
</p>
  <p>IVA:<br>
    <input type="text" name="iva">
</p>
  <p>
    <input type="submit" value="Genera ODC / Impuestos">
</p>
</form>
</body>
</html>
<?php
mysql_free_result($ODC_AUT);
?>
