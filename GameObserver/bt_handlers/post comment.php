<?
include "../script.php";
var_dump($_POST);
if(!isset($_POST['game'])) die("ERROR: Game not found");
if(!isset($_POST["text"])) die("ERROR: Comment text not found");
$user = get_user();
$text = $_POST["text"];

if(str_contains($text,'\'')) {
    $text = strtr($text,['\''=>'\'\'']);
}
if(!sqlsrv_query($connection, 
"INSERT INTO Comments(Text, User_Id)
VALUES
('".$text."', ".$user->Id.");")) {
    error("<br>ERROR AT {INSERT INTO Comments(Text, User_Id)
        VALUES ('".$text."', ".$user->Id.");}<br>");
    var_dump(sqlsrv_errors());
    die("<br>ERROR: Unable to add comment");
}
header("location: ../game.php?game=".$_POST["game"]);
?>