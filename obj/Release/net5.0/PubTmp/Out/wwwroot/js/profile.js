addSkill("Visual Studio", "Expert +10", "100");
addSkill("Application Development", "Expert +10", "100");
addSkill("Automation", "Expert +10", "100");
addSkill("VB", "Intermediate +8.6", "86");
addSkill("C#", "Intermediate +8.5", "85");
addSkill("SQL", "Intermediate +8.4", "84");
addSkill("OOP", "Intermediate +8.3", "83");
addSkill("MVC", "Intermediate +8", "80");
addSkill("MEAN Stack", "Novice +6", "60");
addSkill("Angular", "Novice +5.8", "58");
addSkill("NPM", "Novice +4.7", "47");
addSkill("Node.js", "Novice 4.3", "43");
addSkill("React", "Learning + 1.5", "15");

//addSkill("React", "Beginner", "25");

function addSkill(skillName, pbText, exp) {
    var myList = document.getElementById("ulGroup");
    //myList.style.overflow = "Auto";

    var newLstItem = document.createElement("li");
    newLstItem.classList.add("list-group-item");

    var lblItem = document.createElement("label");
    lblItem.innerText = skillName;

    var pbRow = document.createElement("div");
    pbRow.classList.add("row");

    var pbBlock = document.createElement("div");
    pbBlock.classList.add("col-sm-12");
    pbBlock.classList.add("col-md-12");
    pbBlock.classList.add("col-lg-12");

    var pbwrap = document.createElement("div");
    pbwrap.classList.add("progress");

    var pb = document.createElement("div");
    pb.classList.add("progress-bar");
    pb.classList.add("bg-success");
    pb.style.width = exp + "%";
    pb.innerText = pbText;

    //var bdg = document.createElement("span");
    //bdg.classList.add("badge");
    //bdg.classList.add("badge-primary");
    //bdg.classList.add("badge-pill");
    //bdg.innerText = "+" + exp;

    //var bdgBlock = document.createElement("div");
    //bdgBlock.classList.add("col-sm-2");
    //bdgBlock.classList.add("col-md-2");
    //bdgBlock.classList.add("col-lg-2");

    pbwrap.appendChild(pb);
    pbBlock.appendChild(pbwrap);
    //bdgBlock.appendChild(bdg);
    pbRow.appendChild(pbBlock);
    //pbRow.appendChild(bdgBlock);
    newLstItem.appendChild(lblItem);
    newLstItem.appendChild(pbRow);
    myList.appendChild(newLstItem);
}

//<li class="list-group-item">
//    <label>C#</label>
//    <div class="row">
//        <div class="col-sm-10 col-md-10 col-lg-10">
//            <div style="width:100%">
//                <div class="progress">
//                    <div class="progress-bar" role="progressbar" style="width: 50%" aria-valuenow="15" aria-valuemin="0" aria-valuemax="100"></div>
//                </div>
//            </div>
//        </div>
//        <div class="col-sm-2 col-md-2 col-lg-2">
//            <span class="badge badge-primary badge-pill">+14</span>
//        </div>
//    </div>
//</li>