<?
if(!empty($_COOKIE['name'])){
    $name = $_COOKIE['name'];
}
else $name ="Не задано";

if(!empty($_COOKIE['email'])){
    $email = $_COOKIE['email'];
}
else $email = "Не задан!";
?>
<!DOCTYPE html>
<html>
    <head>
    <link href="favicon.png" rel="icon" type="image/png">
    <meta charset="utf-8">
    <title>Мой профиль</title> 
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="style.css">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    </head>
    <style>
        #info{
            width: 31%;
            margin-top: 3%;
        }
        #l_profile{
            text-align: center;
            font-family: math;
            font-size: 200%;
            margin-top: 50%;
        }
        #logoff{
            border-radius: 9px;
        }

    </style>
    <body class="bg-dark text-light">
        <div class="container" id="info">
            <div id='l_profile'>ПРОФИЛЬ</div>
            <div class="col">Имя: <?echo($name);?></div>
            <div class="col">Почта: <?echo($email)?></div>
            <div class="col"><a href="index.php">Вернуться</a></div>

            <button id="bt_logoff" onclick="logoff()">Выйти из аккаунта</button>

        </div>            
        </div>
        <script>
            function logoff(name){
                document.cookie = "name=''; max-age=-1";
                document.cookie = "email=''; max-age=-1";
                window.location.replace("index.php");
            }
            </script>
    </body>
</html>