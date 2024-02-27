<?php
$server = 'localhost';
$user = 'root';
$password = "";
$dbname = 'test';
$conn = new mysqli($server, $user, $password, $dbname);
if ($conn->connect_error) {
    die('Connection error'. $conn->connect_error);
}
echo "Connection succesfully!";
?>