<?php
# FileName="Connection_php_mysql.htm"
# Type="MYSQL"
# HTTP="true"
$hostname_comprashgo = "crit.mx";
$database_comprashgo = "COMPRAS_HGO";
$username_comprashgo = "comprasrpt";
$password_comprashgo = "RxZPPR4cxQ";
$comprashgo = mysql_connect($hostname_comprashgo, $username_comprashgo, $password_comprashgo) or trigger_error(mysql_error(),E_USER_ERROR); 
mysql_query("SET NAMES 'utf8'");

?>