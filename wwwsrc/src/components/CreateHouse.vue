<template>
  <div class="create-house">
    <form @submit.prevent="createHouse()">
      <div class="form-group">
        <label for="bedrooms">Bedrooms</label>
        <input
          type="number"
          name="bedrooms"
          class="form-control"
          placeholder="Enter number of bedrooms...."
          v-model="newHouse.bedrooms"
        />
      </div>
      <div class="form-group">
        <label for="bathrooms">Bathrooms</label>
        <input
          type="number"
          name="bathrooms"
          class="form-control"
          placeholder="Enter number of bathrooms...."
          v-model="newHouse.bathrooms"
        />
      </div>
      <div class="form-group">
        <label for="levels">Levels</label>
        <input
          type="number"
          name="levels"
          class="form-control"
          placeholder="Enter number of levels...."
          v-model="newHouse.levels"
        />
      </div>
      <div class="form-group">
        <label for="year">Year</label>
        <input
          type="number"
          name="year"
          class="form-control"
          placeholder="Enter year built...."
          v-model="newHouse.year"
        />
      </div>
      <div class="form-group">
        <label for="price">Price</label>
        <input
          type="number"
          name="price"
          class="form-control"
          placeholder="Enter price...."
          v-model="newHouse.price"
        />
      </div>
      <div class="form-group">
        <label for="imgUrl">imgUrl</label>
        <input
          type="text"
          name="imgUrl"
          class="form-control"
          placeholder="Paste Url...."
          v-model="newHouse.imgUrl"
        />
      </div>
      <div class="form-group">
        <label for="body">Description</label>
        <input
          type="text"
          name="body"
          class="form-control"
          placeholder="Enter description...."
          v-model="newHouse.body"
        />
      </div>
      <button class="btn btn-primary" type="submit">Add House</button>
    </form>
  </div>
</template>


<script>
export default {
  name: "create-house",
  data() {
    return {
      newHouse: {}
    };
  },
  computed: {},
  methods: {},
  components: {}
};
</script>


<style scoped>
</style>