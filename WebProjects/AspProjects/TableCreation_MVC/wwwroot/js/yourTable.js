function redirectToCreateRow()
{
    window.location.href = "/Home/CreateRow";
}

document.getElementById('btn1').addEventListener('click',redirectToCreateRow);

document.getElementsByTagName('table')[0].className = 'table table-striped';