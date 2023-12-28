var body = document.body;

var btn = document.getElementById('btn');

btn.onclick = function() {
    let text = document.getElementById('count');

    let form = document.getElementById('form1');

    for (let i = 0; i < Number(text.value); i++)
    {
        let input = document.createElement('input');
        input.name = "value";

        form.appendChild(input);
    }

    let submit = document.createElement('input');
    submit.type = 'submit';

    form.appendChild(submit);
}