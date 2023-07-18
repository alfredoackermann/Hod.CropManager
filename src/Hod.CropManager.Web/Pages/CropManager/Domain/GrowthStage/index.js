$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.growthStage;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/GrowthStage/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/GrowthStage/EditModal');

    var dataTable = $('#GrowthStageTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('GrowthStageDeletionConfirmationMessage', data.record.id);
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
                title: l('GrowthStageCrop'),
                data: "crop"
            },
            {
                title: l('GrowthStageCropId'),
                data: "cropId"
            },
            {
                title: l('GrowthStageStage'),
                data: "stage"
            },
            {
                title: l('GrowthStageDate'),
                data: "date"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewGrowthStageButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
