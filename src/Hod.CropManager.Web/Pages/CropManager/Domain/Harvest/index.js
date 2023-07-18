$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.harvest;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Harvest/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Harvest/EditModal');

    var dataTable = $('#HarvestTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('HarvestDeletionConfirmationMessage', data.record.id);
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
                title: l('HarvestCrop'),
                data: "crop"
            },
            {
                title: l('HarvestCropId'),
                data: "cropId"
            },
            {
                title: l('HarvestStartDate'),
                data: "startDate"
            },
            {
                title: l('HarvestEndDate'),
                data: "endDate"
            },
            {
                title: l('HarvestYeld'),
                data: "yeld"
            },
            {
                title: l('HarvestQuality'),
                data: "quality"
            },
            {
                title: l('HarvestEquipment'),
                data: "equipment"
            },
            {
                title: l('HarvestEquipmentId'),
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

    $('#NewHarvestButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
