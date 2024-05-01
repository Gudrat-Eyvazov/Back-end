// setTimeout(() => addForm(), 0);

document.querySelector('.add_passenger').addEventListener('click', () => {
    addForm();
});

let count = 0;
const formsBlock = document.querySelector('.passenger_info_wrapper');

const addForm = (count = 0) => {
    formsBlock.innerHTML += `<div class="passenger_info"><div class="passport_wrapper">${formGenerator(count)}</div></div>`;
    count++;
}

const formGenerator = (count) => {
    return (`
    <form class="user_passport">
    <div class="user_information item1">
        <label for="first_name${count}">Ad</label>
        <input type="text" placeholder="Ehtiram" id="first_name${count}">
    </div>
    <div class="user_information item2">
        <label for="last_name${count}">Soyad</label>
        <input type="text" placeholder="İbrahimov" id="last_name${count}">
    </div>
    <div class="user_information item3">
        <label for="gender${count}">Cinsi</label>
        <select name="gender" id="gender${count}">
            <option value="gender">Kişi</option>
            <option value="gender">Qadın</option>
        </select>
    </div>
    <div class="user_information item4">
        <label for="citizenship${count}">Vətəndaşlıq</label>
        <input type="text" placeholder="Azerbaycanli" id="citizenship${count}">
    </div>
    <div class="user_information item5">
        <label for="birth${count}">Doğum tarixi</label>
        <div class="date_input">
            <input id="birth${count}" type="text" placeholder="31">
            <input type="text" placeholder="Iyul">
            <input type="text" placeholder="1993">
        </div>
    </div>
    <div class="user_information item6">
        <label for="id${count}">Senedin seriyasi ve nomresi</label>
        <input id="id${count}" type="text" placeholder="AZE &nbsp;&nbsp; 0213456789">
    </div>
    <div class="user_information item7">
        <label for="time${count}">Muddeti</label>
        <div class="date_input">
            <input id="time${count}" type="text" placeholder="13">
            <input type="text" placeholder="Avqust">
            <input type="text" placeholder="2024">
        </div>
    </div>
    <div class="user_information item8">
        <label for="milcard${count}">Mil kartı</label>
        <input type="text" id="milcard${count}" placeholder="Mil karti">
    </div>
</form>
    `);
}