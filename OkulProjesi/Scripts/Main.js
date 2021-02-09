$(document).on("clik", "ogrenciKaydet", function () {
    const { value: formValues } = await Swal.fire({
        title: 'Multiple inputs',
        html:
            '<input id="swal-input1" class="swal2-input">' +
            '<input id="swal-input2" class="swal2-input">',
        focusConfirm: false,
        preConfirm: () => {
            return [
                document.getElementById('swal-input1').value,
                document.getElementById('swal-input2').value
            ]
        }
    })

    if (formValues) {
        Swal.fire(JSON.stringify(formValues))
    }
});

$(document).on("click", ".guncelle", function () {
    var ogrnciId = $(this).val();
    var ogrnciAd = $(this).parent("td").
});
$(document).on("click", "#ogrenciGuncelle", function ({

va})