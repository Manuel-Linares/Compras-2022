<?php require_once('../Connections/comprashgo.php'); ?>
<link rel="shortcut icon" href="favicon.ico">
<?php
mysql_select_db($database_comprashgo, $comprashgo);
$query_Recordset1 = "SELECT id FROM ODC_AUTORIZADAS WHERE estatus = 'Autorizada DO' ORDER BY id DESC";
$Recordset1 = mysql_query($query_Recordset1, $comprashgo) or die(mysql_error());
$row_Recordset1 = mysql_fetch_assoc($Recordset1);
$totalRows_Recordset1 = mysql_num_rows($Recordset1);
?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<title>Documento sin t&iacute;tulo</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
</head>

<body>
<form action="https://infosit.mx/comprashgo/formatorequi/odcexentoiva.php?<?php echo $_GET['id']; ?>=<?php echo $_GET['id']; ?>">
  <p>
    <select name="id">
      <?php
do {  
?>
      <option value="<?php echo $row_Recordset1['id']?>"><?php echo $row_Recordset1['id']?></option>
      <?php
} while ($row_Recordset1 = mysql_fetch_assoc($Recordset1));
  $rows = mysql_num_rows($Recordset1);
  if($rows > 0) {
      mysql_data_seek($Recordset1, 0);
	  $row_Recordset1 = mysql_fetch_assoc($Recordset1);
  }
?>
    </select>
  </p>
  <p>
    <input type="submit" value="Generar ODC Exento de IVA">
</p>
</form>
</body>
</html>
<?php
mysql_free_result($Recordset1);
?>
