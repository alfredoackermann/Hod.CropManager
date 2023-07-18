$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.fertilizationSchedule;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/FertilizationSchedule/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/FertilizationSchedule/EditModal');

    var dataTable = $('#FertilizationScheduleTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('FertilizationScheduleDeletionConfirmationMessage', data.record.id);
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
                title: l('FertilizationScheduleCrop'),
                data: "crop"
            },
            {
                title: l('FertilizationScheduleCropId'),
                data: "cropId"
            },
            {
                title: l('FertilizationScheduleFertilizer'),
                data: "fertilizer"
            },
            {
                title: l('FertilizationScheduleFertilizerId'),
                data: "fertilizerId"
            },
            {
                title: l('FertilizationScheduleDate'),
                data: "date"
            },
            {
                title: l('FertilizationScheduleApplicationMethod'),
                data: "applicationMethod"
            },
            {
                title: l('FertilizationScheduleQuantity'),
                data: "quantity"
            },
            {
                title: l('FertilizationScheduleEquipment'),
                data: "equipment"
            },
            {
                title: l('FertilizationScheduleEquipmentId'),
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

    $('#NewFertilizationScheduleButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
