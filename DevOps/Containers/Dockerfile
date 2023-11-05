# Use CentOS latest image as the base
FROM centos:latest

# Update the system and install basic tools
RUN yum -y update && \
    yum -y install wget \
                   vim \
                   net-tools \
                   curl && \
    yum clean all

# Set environment variables, if any
ENV MY_ENVIRONMENT_VAR=value

# Set the working directory in the container
WORKDIR /usr/src/myapp

# Copy files from your host to your current location.
COPY ./myapp /usr/src/myapp

# Set the default command to execute
# when creating a new container
CMD ["/bin/bash"]
