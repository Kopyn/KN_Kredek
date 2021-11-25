//variable to store last score
let lastScore = 0;

//variable to store number of best attempts
let scoresAmount = 10;

//array containing best scores
let scores = [];

//dino object
const dino = document.getElementById("trex");

//cactus object
const cactus = document.getElementById("obstacle");

//variable storing score
let score = 0;

//flag to fill score table
let flag = true;

//function to jump with dino
function jump() {
    if (dino.classList != "jump") {
        //add jump class to dino object
        dino.classList.add("jump");

        //make dino jump multiple times
        setTimeout(function () {
            dino.classList.remove("jump");
        }, 300);
    }
}

let isAlive = setInterval(function () {
    //get dino Y position
    let dinoTop = parseInt(window.getComputedStyle(dino).getPropertyValue("top"));
    //get cactus X position
    let cactusLeft = parseInt(window.getComputedStyle(cactus).getPropertyValue("left"));
    console.log(cactusLeft);

    //collision detection
    if (cactusLeft <= 20 && cactusLeft > 0 && dinoTop >= 221) 
    {
        //collision
        console.log("collision");
        //reset points
        score = 0;
        
    }
    else if (cactusLeft <= 20 && cactusLeft > 0 && dinoTop < 221)
    {
        //point
        console.log("point");
        //add a point
        score++;
        //increase score
        document.getElementById("score-value").innerHTML = "<h1 id=score-value>" + score + "</h1>";
    }
}, 10);

//Jump after pressing space
document.addEventListener("keyup", function (event) {
    if (event.keyCode == 32) {
        jump();
    }
});

//function to show game panel
function ShowGamePanel() {
    window.open("game.html", "_self");
}

//function to show scoreboard
function ShowScoreboard() {
    window.open("scoreboard.html", "_self");
}

//function to start the game
function StartGame() {
    window.open("game.html", "_self");
    setTimeout(newGame, 100);
}

//function to play new game
function NewGame() {
    setInterval(isAlive, 1);
}

//function to update scoreboard table
function UpdateTable(score) {
    console.log(document.getElementById("scores-table").innerHTML);

}

