<template>
  <div class="dashboard">
    <h1>WELCOME TO THE DASHBOARD</h1>
    <div class="row">
      <div class="col-4 ml-2">
        <create-car></create-car>
      </div>
    </div>
    <cars></cars>
    <houses></houses>
  </div>
</template>

<script>
import CreateCar from "../components/CreateCar.vue";
import Cars from "../components/Cars.vue";
import Houses from "../components/Houses.vue";
export default {
  mounted() {},
  computed: {},
  components: { CreateCar, Cars, Houses }
};
</script>

<style></style>
