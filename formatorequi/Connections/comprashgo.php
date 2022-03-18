<?php

# FileName="Connection_php_mysql.htm"

# Type="MYSQL"

# HTTP="true"

$hostname_comprashgo = "controlsit.mx";

$database_comprashgo = "controls_Compras_HGO";

$username_comprashgo = "controls_comhgo";

$password_comprashgo = "Godinez*19";

$comprashgo = mysqli_connect($hostname_comprashgo, $username_comprashgo, $password_comprashgo) or trigger_error(mysqli_error(),E_USER_ERROR); 

mysqli_query($comprashgo, "SET NAMES 'utf8'");



?>