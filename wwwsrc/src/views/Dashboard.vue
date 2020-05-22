<template>
  <div class="dashboard">
    <h1>WELCOME TO THE DASHBOARD</h1>
    <div class="row justify-content-between">
      <div class="col-3 ml-2">
        <create-car></create-car>
      </div>
      <div class="col-3">
        <create-house></create-house>
      </div>
      <div class="col-3 mr-2">
        <create-job></create-job>
      </div>
    </div>
    <cars></cars>
    <houses></houses>
    <jobs></jobs>
  </div>
</template>

<script>
import CreateCar from "../components/CreateCar.vue";
import Cars from "../components/Cars.vue";
import CreateHouse from "../components/CreateHouse.vue";
import Houses from "../components/Houses.vue";
import CreateJob from "../components/CreateJob.vue";
import Jobs from "../components/Jobs.vue";
export default {
  mounted() {},
  computed: {},
  components: { CreateCar, Cars, CreateHouse, Houses, CreateJob, Jobs }
};
</script>

<style></style>
