<?
$games = [];
$users = [];
$genres = [];
class User{
    public $Name;
    public $Password;
    public $Email;
    function args(string $name, string $pass, string $email){
        $this->Name = $name; $this->Password = $pass; $this->Email = $email;
    }
}
class Game{
    public $Id;
    public $Name;
    public $Description;
    public $Steam;
}
class Genre{
    public $Name;
    public $Game;
}

function connect(){
    if($connection = sqlsrv_connect("HOME-PC\SQLEXPRESS",array("Database"=>"ObserverDB"))) return $connection;
    else die("ERROR: Connection failed");
}

function get_user(){
    if(!isset($_COOKIE["name"])) return;
    $connection = connect();
    $stmt = sqlsrv_query($connection,"SELECT * FROM dbo.Users WHERE Users.Name = '".$_COOKIE["name"]."'");
    $user = sqlsrv_fetch_object($stmt,'User');
    if(!$user) die("ERROR: Unable to get user");
    return $user;
}

function get_comments(){
    $connection = connect();
    if(!$stmt = sqlsrv_query($connection, 
    "SELECT dbo.Comments.Id AS 'CommentId', User_Id AS 'UserId', Text, dbo.Users.Name AS 'Username' FROM dbo.Comments, dbo.Users WHERE User_Id = Users.Id;")){
        var_dump(sqlsrv_errors());
    };
    $arr = array();
    while ($i = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC)){
        array_push($arr, $i);
    };
    if(!$arr) {
        return false;
    }
    return $arr;
}
function error(string $text){
    echo("ERROR: ".$text);
}
function get_game($id = null){
    //Если id == null, возвращает все игры
    $connection = connect();

    if($id) { $stmt = sqlsrv_query($connection,"SELECT * FROM dbo.Games WHERE Id = ".$_GET["game"]); }

    else { $stmt = sqlsrv_query($connection,"SELECT * FROM dbo.Games"); }

    if(!$stmt) die("ERROR: Unable to get game");
    if(!$game = sqlsrv_fetch_object($stmt, 'Game')) die("ERROR: Unable to get game");
    return $game;
}
function fetch(array $arr, $stmt, string $class_name){
    while($i = sqlsrv_fetch_object($stmt,$class_name)){
        //var_dump($i); echo "<br>";
        array_push($arr, $i);
    }
    return $arr;
}
$connection = connect();
//echo("Connected to ".sqlsrv_server_info($connection)["SQLServerName"]."<br>");
$stmt =sqlsrv_query($connection, "SELECT * FROM dbo.Games");
$games = fetch($games,$stmt,"Game");
$stmt = sqlsrv_query($connection,"SELECT * FROM dbo.Users");
$users = fetch($users,$stmt,"User");
$stmt = sqlsrv_query($connection, "SELECT Genres.[Name] AS 'Name', Games.[Name] AS 'Game' FROM dbo.Genres, dbo.Games");
$genres = fetch($genres,$stmt,"Genre");
$users = sqlsrv_fetch_object(sqlsrv_query($connection,"SELECT * FROM dbo.Users"),"User");
$genres = sqlsrv_fetch_object(sqlsrv_query($connection, "SELECT Genres.[Name] AS 'Name', Games.[Name] AS 'Game' FROM dbo.Genres, dbo.Games"),"Genre");
?>