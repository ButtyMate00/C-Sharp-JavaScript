<?php  include("connect.php") ?>

<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Dolgozó</h1>
    <form method="POST" action="<?php echo'$_SERVER[$PHP_SELF]' ?>">
    <table>
        <tr>
            <td>Törzsszám</td>
            <td><input type="text" name="tsz" id="tsz" maxlenght="7"></td>
        </tr>
        <tr>
            <td>Dolgozó neve:</td>
            <td><input type="text" name="nev" id="nev"></td>
        </tr>
        <tr>
            <td>Születési hely:</td>
            <td><input type="text" name="szhely" id="szhely"></td>
        </tr>
        <tr>
            <td>Születési dátuma:</td>
            <td><input type="date" name="szdate" id="szdate"></td>
        </tr>
        <tr>
            <td>Dolgozó fizetése:</td>
            <td><input type="text" name="fizetes" id="fizetes"></td>
        </tr>
        <tr style="text-align: center;">
            <td><input type="submit" value="Elküld"></td>
            <td><input type="reset" value="Töröl"></td>
        </tr>
    </table>
    </form>
<?php
    $sql = 'CREATE TABLE IF NOT EXISTS dolgozo (torzsszam VARCHAR(7) PRIMARY KEY, nev VARCHAR(30), szul_hely VARCHAR(50), szul_ido DATE, fizetes DECIMAL(7, 2))';

    if ($conn->query($sql)){
        echo 'A tabla létrahozása sikeres!';
    }
    else {
        echo 'A táblázat nem jött létre.';
    }

    $sql = "INSERT INTO dolgozo VALUES (".$_POST['tsz'].", ".$_POST['nev'].", ".$_POST['szhely'].",".$_POST['szdate'].",".$_POST['fizetes'].");";

    if ($conn->query($sql)){
        echo "Az adat felvitele sikeres!";
    }
    else {
        echo "Az adat felvétele sikertelen";
    }

    $conn->close();
?>

</body>
</html>