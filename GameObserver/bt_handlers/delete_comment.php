<?
include '../script.php';
var_dump($_GET);
$stmt = sqlsrv_query($connection, "DELETE FROM dbo.Comments WHERE Id = ".$_GET['id']);
if(!$stmt) {var_dump(sqlsrv_errors()); die;}
if(!sqlsrv_begin_transaction($connection)){var_dump(sqlsrv_errors());die;};
header("location:../game.php?game=".$_GET["gameId"]);
?>