$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.pesticideSchedule;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/PesticideSchedule/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/PesticideSchedule/EditModal');

    var dataTable = $('#PesticideScheduleTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('PesticideScheduleDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('PesticideScheduleCrop'),
                data: "crop"
            },
            {
                title: l('PesticideScheduleCropId'),
                data: "cropId"
            },
            {
                title: l('PesticideSchedulePesticide'),
                data: "pesticide"
            },
            {
                title: l('PesticideSchedulePesticideId'),
                data: "pesticideId"
            },
            {
                title: l('PesticideScheduleDate'),
                data: "date"
            },
            {
                title: l('PesticideScheduleApplicationMethod'),
                data: "applicationMethod"
            },
            {
                title: l('PesticideScheduleQuantity'),
                data: "quantity"
            },
            {
                title: l('PesticideScheduleEquipment'),
                data: "equipment"
            },
            {
                title: l('PesticideScheduleEquipmentId'),
                data: "equipmentId"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewPesticideScheduleButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
