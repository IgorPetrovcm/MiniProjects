var btn_add = document.getElementById('btn_addRow');
btn_add.addEventListener('click',addColumns);

var input_countColumn = document.getElementById('countColumn');

var smallMessage = document.getElementById('smallMessage');

input_countColumn.onchange = function ()
{
    btn_add.disabled = true;
    if (isNaN(this.value)) {
        smallMessage.innerText = 'Input value must by a number';
        return;
    }   
    if (Number(this.value) > 10 || Number(this.value) < 1)
    {
        smallMessage.innerText = 'Input value > 0 and < 11';
        return;
    }
    btn_add.disabled=false;
    smallMessage.innerText = 'Ok';
}

function addColumns()
{
    append(document.createElement('br'), document.body);

    let div = document.createElement('div');
    append(div,document.body);

    let form = document.createElement('form');
    form.method = 'post';
    append(form,div);

    let table = document.createElement('table');
    append(table,form);
    
    let tr = document.createElement('tr');
    append(tr,table);

    for (let i = 1; i <= input_countColumn.value; i++)
    {
        let th = document.createElement('th');

        let input = document.createElement('input');
        input.name = 'values';
        input.className = 'form-control';
        input.placeholder = 'Column name';
        
        input.onchange = function () 
        {
            submit.disabled = true;

            if (this.value == '')
            {
                this.value = null;
                this.placeholder = 'Name cannot be empty';
                return;
            }
            if (this.value.length > 20 || this.value.length < 1)
            {
                this.value = null;
                this.placeholder = 'Name length < 21';
                return;
            }

            submit.disabled = false;
        }

        append(input,th);
        append(th,tr);
    }

    append(document.createElement('br'),form);

    let submit = document.createElement('button');
    submit.innerText = "Create columns";
    submit.className = 'btn btn-primary';
    submit.disabled = true;

    append(submit, form);
}

function append(added,head)
{
    head.appendChild(added);
}