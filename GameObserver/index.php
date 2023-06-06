<!DOCTYPE html>
<html>
    <head>
    <meta charset="utf-8">
    <title>Game Observer</title> 
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="style.css">
    <link href="favicon.png" rel="icon" type="image/png">
    </head>
    <body class="bg-dark text-light">
        <style>
        .game{
            margin-top: 3%;
            display: flex;
            padding: 10px;
        }
        #user_guest{
            width: 24%;
            margin-left: 36% ;
        }
        #user_img{
            margin-left: 47%;
            margin-bottom:1%;
        }
        </style>
        <div class="container">
            <?
            if(isset($_COOKIE["name"])) echo("<a href='profile.php'><img src='Pictures/icon.jpg' id='user_img'></a>");
            else echo("<img src='Pictures/icon.jpg' id='user_img'>");

            ?>
            
            <div class="col" <?
            if(empty($_COOKIE["name"])) {echo("id= 'user_guest'>Гость( Не зарегестрирован )");
            }
            else echo("id= 'user'>Пользователь: <a href='profile.php'>".$_COOKIE['name']."</a>");
                ?>
            </div>
        </div>
        <div class="container-fluid text-center" id="main">
            <div class="row">
                <div class="col col_menu">Жанры</div>
                <div class="col col_menu"><a href="reg.php">Регистрация/Вход</a></div>
            </div>
        </div>
        <div class="container text-center">
            <div class="row games">
                    <?
                    include 'script.php';
                    if(count($games)>0)
                        foreach($games as $i){
                            $desired_length = 1000;
                            if(strlen($i->Description) > $desired_length){$i->Description = str_split($i->Description, $desired_length)[0]."...";}
                            echo("<div class='col game'><a href='game.php?game=".$i->Id."'><img class = preview_pic col src='/Pictures/Previews/".$i->Name."/".$i->Name.".png'/></a><div class = 'description'><span class = game_name>".$i->Name."</span><p>".$i->Description."</p></div></div>"); 
                    }
                    else echo("<h1>В базе данных пока нет ни одной игры. Добавьте игры через AdminPanel</h1>");
                    ?>
        </div>
        <script src="script.php"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    </body>
</html>