<?php

$host = "localhost";
$user = "root";
$pass = "";
$bd = "files";

$mysql = new mysqli($host, $user, $pass, $bd);

/* chack connection */
if ($mysql->connect_errno) {
    echo "connect falied: " . $mysql->connect_error;
        exit();
}