 // hide input feild upon what is choosen in previous dropdown list 
    function showMe(e) {
        var strdisplay = e.options[e.selectedIndex].value;
        var e = document.getElementById("idShowMe");
        if (strdisplay == "False") {
            e.style.display = "none";
        } else {
            e.style.display = "block";
        }
    }