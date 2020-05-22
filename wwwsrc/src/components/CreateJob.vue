<template>
  <div class="create-job">
    <form @submit.prevent="addJob()">
      <div class="form-group">
        <label for="title">Title</label>
        <input
          type="text"
          name="title"
          class="form-control"
          placeholder="Enter job title...."
          v-model="newJob.title"
        />
      </div>
      <div class="form-group">
        <label for="salary">Yearly Salary</label>
        <input
          type="number"
          name="salary"
          class="form-control"
          placeholder="Enter yearly salary...."
          v-model="newJob.salary"
        />
      </div>
      <div class="form-group">
        <label for="hours">Hours per week</label>
        <input
          type="number"
          name="hours"
          class="form-control"
          placeholder="Enter hours to be worked per week...."
          v-model="newJob.hoursweek"
        />
      </div>
      <div class="form-group">
        <label for="location">City, State</label>
        <input
          type="text"
          name="location"
          class="form-control"
          placeholder="Enter city and state...."
          v-model="newJob.citystate"
        />
      </div>
      <div class="form-group">
        <label for="body">Description</label>
        <input
          type="text"
          name="body"
          class="form-control"
          placeholder="Enter job description...."
          v-model="newJob.body"
        />
      </div>
      <button class="btn btn-block btn-primary" type="submit">Add Job</button>
    </form>
  </div>
</template>


<script>
export default {
  name: "create-job",
  data() {
    return {
      newJob: {}
    };
  },
  computed: {},
  methods: {
    addJob() {
      this.newJob.salary = +this.newJob.salary;
      this.newJob.hoursweek = +this.newJob.hoursweek;
      this.$store.dispatch("addJob", this.newJob);
    }
  },
  components: {}
};
</script>


<style scoped>
</style>