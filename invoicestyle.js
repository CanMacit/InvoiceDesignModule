
function allowDrop(ev) {
    ev.preventDefault();
}

function drag(ev) {
    ev.dataTransfer.setData("Text", ev.target.id);
}

function drop(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("Text");
    ev.target.appendChild(document.getElementById(data));
}



function onClick() {
    document.getElementById("ImageCompanyLogo").draggable = false;
    document.getElementById("ImageGibLogo").draggable = false;
    document.getElementById("CostumerInfoTable").draggable = false;
    document.getElementById("ServicerInfoTable").draggable = false;
    document.getElementById("InvoiceInfoTable").draggable = false;

    document.getElementById("DesingPanelDiv").remove();


    var markup = document.documentElement.innerHTML;
    document.getElementById("lblhtmloutput").innerText = "<!DOCTYPE html>" + "<html>" + markup + "</html>";
}



(function () {
    var textFile = null,
        makeTextFile = function (text) {
            var data = new Blob([text], { type: 'text/plain' });

            // If we are replacing a previously generated file we need to
            // manually revoke the object URL to avoid memory leaks.
            if (textFile !== null) {
                window.URL.revokeObjectURL(textFile);
            }

            textFile = window.URL.createObjectURL(data);

            return textFile;
        };


    var create = document.getElementById('create'),
        textbox = document.getElementById('textbox');
    textboxinnerhtml = document.getElementById('textbox').innerHTML;

    create.addEventListener('click', function () {
        
        var link = document.getElementById('downloadlink');
       
        var copytext = textbox.value;
        var index = copytext.indexOf("textarea")
        var first = copytext.slice(0, index - 1)
        var second = copytext.slice(index + 91,copytext.length-1)
        var printabletext = first+second
       
        link.href = makeTextFile(printabletext);
        
        link.style.display = 'block';
    }, false);
})();







