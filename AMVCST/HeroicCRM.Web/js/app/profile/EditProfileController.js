﻿(function() {
	'use strict';

	window.app.controller('EditProfileController', EditProfileController);

	EditProfileController.$inject = ['$http'];
	function EditProfileController($http) {
		var vm = this;

		vm.profile = {};
		vm.save = save;
		vm.init = init;

		function init(profile) {
		    vm.profile = profile;
		}

		//$http.post('/Profile/LoadProfile')
		//	.success(function (profile) {
		//		vm.profile = profile;
		//	});

		function save() {
			vm.saving = true;
			vm.errorMessage = null;
			vm.success = false;

			$http.post('/Profile/Update', vm.profile)
				.success(function() {
					vm.success = true;
				})
				.error(function(msg) {
					vm.errorMessage = msg;
				})
				.finally(function() {
					vm.saving = false;
				});
		}
	}
})();